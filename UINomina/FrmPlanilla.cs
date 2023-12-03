using Controladores;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Drawing;
using System.IO;


namespace UINomina
{
    public partial class FrmPlanilla : Form
    {
        private List<Empleado> listaEmpleados;
        private Empleado empleadoSeleccionado;
        public FrmPlanilla()
        {
            InitializeComponent();
        }

        private void FrmPlanilla_Load(object sender, EventArgs e)
        {
            ObtenerDatosListView();
            CargarComboBoxMeta();
        }
        private void CargarComboBoxMeta()
        {
            if (empleadoSeleccionado != null)
            {
                ComisionesController comisionesController = new ComisionesController();
                List<string> valoresMeta = comisionesController.ObtenerMetaVentas(empleadoSeleccionado.IDCargo);

                cmbMetaVenta.Items.Clear(); // Limpia el ComboBox

                if (valoresMeta.Count > 0)
                {
                    cmbMetaVenta.Items.AddRange(valoresMeta.ToArray()); // Agrega los valores al ComboBox
                }
                else
                {
                    // Si no se encontraron valores, puedes mostrar un mensaje o establecer un valor predeterminado.
                    cmbMetaVenta.Items.Add("No hay metas disponibles");
                }
            }
        }


        private void ObtenerDatosListView()
        {
            lvEmpleados.Scrollable = true;
            lvEmpleados.MultiSelect = false;
            lvEmpleados.FullRowSelect = true;

            EmpeladoController empleadoController = new();
            listaEmpleados = empleadoController.TraerEmpleados();

            CargarListView(listaEmpleados);
        }
        private void CargarListView(List<Empleado> empleados)
        {
            lvEmpleados.Items.Clear();

            foreach (Empleado empleado in empleados)
            {
                ListViewItem item = new ListViewItem(empleado.IDEmpleado.ToString());
                item.SubItems.Add(empleado.NumeroCedula);
                item.SubItems.Add(empleado.NumeroINSS);
                item.SubItems.Add(empleado.NumeroRUC);
                item.SubItems.Add(empleado.PrimerNombre);
                item.SubItems.Add(empleado.SegundoNombre);
                item.SubItems.Add(empleado.PrimerApellido);
                item.SubItems.Add(empleado.SegundoApellido);
                item.SubItems.Add(empleado.FechaNacimiento.ToShortDateString());
                item.SubItems.Add(empleado.Sexo);
                item.SubItems.Add(empleado.EstadoCivil);
                item.SubItems.Add(empleado.Direccion);
                item.SubItems.Add(empleado.Telefono);
                item.SubItems.Add(empleado.Celular);
                item.SubItems.Add(empleado.FechaContratacion.ToShortDateString());
                item.SubItems.Add(empleado.SalarioOrdinario.ToString("C"));
                string nombreCargo = ObtenerNombreCargoPorId(empleado.IDCargo);
                item.SubItems.Add(nombreCargo);
                if (empleado.IDHorario == (int)Horario.idDiurno)
                    item.SubItems.Add("Diurno");
                else if (empleado.IDHorario == (int)Horario.idNocturno)
                    item.SubItems.Add("Nocturno");
                else if (empleado.IDHorario == (int)Horario.idMixto)
                    item.SubItems.Add("Mixto");
                lvEmpleados.Items.Add(item);
            }
        }
        private string ObtenerNombreCargoPorId(int idCargo)
        {
            CargoController cargoController = new CargoController();
            Cargo cargo = cargoController.ObtenerCargos().FirstOrDefault(c => c.IDCargo == idCargo);

            if (cargo != null)
            {
                return cargo.Nombre;
            }

            return string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = txtBusqueda.Text.Trim();

            if (!string.IsNullOrEmpty(nombreBusqueda) && listaEmpleados != null)
            {
                List<Empleado> empleadosFiltrados = BuscarEmpleadosPorNombre(nombreBusqueda);

                if (empleadosFiltrados.Count > 0)
                {
                    CargarListView(empleadosFiltrados);
                }
                else
                {
                    MessageBox.Show("No se encontraron empleados que coincidan con la búsqueda.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                CargarListView(listaEmpleados);
            }
        }
        private List<Empleado> BuscarEmpleadosPorNombre(string nombreBusqueda)
        {
            if (listaEmpleados == null)
            {
                return new List<Empleado>();
            }

            var empleadosFiltrados = listaEmpleados
                .Where(empleado =>
                    empleado.PrimerNombre.Contains(nombreBusqueda, StringComparison.OrdinalIgnoreCase) ||
                    empleado.SegundoNombre.Contains(nombreBusqueda, StringComparison.OrdinalIgnoreCase) ||
                    empleado.PrimerApellido.Contains(nombreBusqueda, StringComparison.OrdinalIgnoreCase) ||
                    empleado.SegundoApellido.Contains(nombreBusqueda, StringComparison.OrdinalIgnoreCase) ||
                    empleado.NumeroINSS.Contains(nombreBusqueda, StringComparison.OrdinalIgnoreCase) ||
            empleado.NumeroCedula.Contains(nombreBusqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return empleadosFiltrados;
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            ObtenerDatosListView();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado != null)
            {
                NominaController nominaC = new();
                if (RBQuincenal.Checked)
                {
                    Nomina nomina = cargarNomina();
                    List<string> errores = Validation.ValidarModelo(nomina);
                    if (errores.Count == 0)
                    {
                        try
                        {
                            cargarDataGridView(nomina);
                            nominaC.InsertarNomina(nomina);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error en el ingreso de la nomina: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string mensajeErrores = string.Join(Environment.NewLine, errores);
                        MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (RBMensual.Checked)
                {
                    NominaMensual nominaMensual = cargarNominaMensual();
                    List<string> erroresMensual = Validation.ValidarModelo(nominaMensual);
                    if (erroresMensual.Count == 0)
                    {
                        try
                        {
                            cargarDataGridView(nominaMensual);
                            nominaC.InsertarNomina(nominaMensual);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error en el ingreso de la nomina: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string mensajeErrores = string.Join(Environment.NewLine, erroresMensual);
                        MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private NominaMensual cargarNominaMensual()
        {
            NominaMensual nomina = new();
            nomina.Empleado = empleadoSeleccionado;
            nomina.Fecha = dtpFecha.Value;
            nomina.FechaFin = dtpFechaFin.Value;
            nomina.SalarioPorDia = nomina.CalcularSalarioPorDia();
            if (int.TryParse(txtHora.Text, out int horaExtra))
                nomina.HoraExtra = horaExtra;

            if (empleadoSeleccionado.IDHorario == (int)Horario.idNocturno || empleadoSeleccionado.IDHorario == (int)Horario.idMixto)
                nomina.Nocturnidad = nomina.CalcularNocturnidad();
            else
            {
                MessageBox.Show("No se le aplica nocturnidad", "No se aplica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomina.Nocturnidad = 0;
            }
            if (empleadoSeleccionado.IDCargo != null)
            {
                CargoController cargoController = new CargoController();
                Cargo cargo = cargoController.ObtenerCargoPorId(empleadoSeleccionado.IDCargo);

                if (cargo != null)
                {
                    if (cargo.AplicaComisiones)
                    {
                        decimal porcentajeComision = 0;
                        decimal venta = 0;

                        if (decimal.TryParse(txtPorcentaje.Text, out porcentajeComision) &&
                            decimal.TryParse(txtVenta.Text, out venta))
                        {
                            decimal porcentajeComi = venta * porcentajeComision;
                            nomina.Comisiones = porcentajeComi;
                        }
                    }
                    else
                    {
                        nomina.Comisiones = 0;
                        MessageBox.Show("No se le aplica comisiones", "No se aplica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (cargo.AplicaRiesgoLaboral)
                    {
                        nomina.RiesgoLaboral = nomina.CalcularRiesgoLaboral();
                    }
                    else
                    {
                        nomina.RiesgoLaboral = 0;
                        MessageBox.Show("No se le aplica Riesgo laboral", "No se aplica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (decimal.TryParse(txtViaticoAlimentacion.Text, out decimal ViaticoAliementacion))
                    nomina.ViaticoAlimentacion = ViaticoAliementacion;
                if (decimal.TryParse(txtViaticoTransporte.Text, out decimal ViaticoTransporte))
                    nomina.ViaticoTransporte = ViaticoTransporte;
                if (decimal.TryParse(txtDeprecVehiculo.Text, out decimal deprecV))
                    nomina.DepreciacionVehiculo = deprecV;
                if (decimal.TryParse(txtPrestamos.Text, out decimal prestamos))
                    nomina.Prestamos = prestamos;
                nomina.INSS = nomina.CalcularINSS();
                if (decimal.TryParse(txtEmbargos.Text, out decimal embargos))
                    nomina.Embargos = embargos;
                nomina.Antiguedad = nomina.calcularAntiguedad();
                nomina.SalarioNeto = nomina.CalcularSalarioNeto();
                nomina.SalarioPorDia = nomina.CalcularSalarioPorDia();
                nomina.SalarioQuincenal = nomina.calcularSalarioQuincenal();
                nomina.IngresoAguinaldo = nomina.MostrarAguinaldoAcmulado();
                nomina.IngresoVacaciones = nomina.MostrarVacacionesAcumuladas();
                nomina.Indemizacion = nomina.calcularPagoIndenmizacion();
                nomina.OtrosIngresos = Convert.ToDecimal(txtOtrosIngresos.Text);
                nomina.OtrasDeducciones = Convert.ToDecimal(txtOtrasDeducciones.Text);

            }
            return nomina;
        }

        private void cargarDataGridView(Nomina nomina)
        {
            int filaIndex = DGVNomina.Rows.Add();
            DGVNomina.Rows[filaIndex].Cells["Fecha"].Value = nomina.Fecha.ToShortDateString();
            DGVNomina.Rows[filaIndex].Cells["FechaFin"].Value = nomina.FechaFin.ToShortDateString();
            DGVNomina.Rows[filaIndex].Cells["SalarioBase"].Value = empleadoSeleccionado.SalarioOrdinario.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["SalarioDia"].Value = nomina.SalarioPorDia.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["SalarioHora"].Value = nomina.CalcularSalarioPorHora().ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["SalarioQuincenal"].Value = (empleadoSeleccionado.SalarioOrdinario) / 2;
            DGVNomina.Rows[filaIndex].Cells["SalarioNeto"].Value = nomina.CalcularSalarioNeto().ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["Nocturnidad"].Value = nomina.Nocturnidad.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["HorasExtras"].Value = nomina.CalcularHoraExtra().ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["Comisiones"].Value = nomina.Comisiones;
            DGVNomina.Rows[filaIndex].Cells["ViaticoA"].Value = nomina.ViaticoAlimentacion.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["ViaticoT"].Value = nomina.ViaticoTransporte.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["DeprecV"].Value = nomina.DepreciacionVehiculo;
            DGVNomina.Rows[filaIndex].Cells["IngresoVacaciones"].Value = nomina.IngresoVacaciones.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["Aguinaldo"].Value = nomina.IngresoAguinaldo.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["Indemizacion"].Value = nomina.Indemizacion.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["ImpuestoRenta"].Value = nomina.ImpuestoRenta.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["INSS"].Value = nomina.INSS.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["Prestamos"].Value = nomina.Prestamos.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["Embargos"].Value = nomina.Embargos.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["INATEC"].Value = nomina.CalcularINATEC().ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["INSSPatronal"].Value = nomina.CalcularINSSPatronal().ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["IDEmpleado"].Value = empleadoSeleccionado.IDEmpleado;
            DGVNomina.Rows[filaIndex].Cells["Antiguedad"].Value = nomina.Antiguedad.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["RiesgoLaboral"].Value = nomina.RiesgoLaboral.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["OtrosIngresos"].Value = nomina.OtrosIngresos.ToString("C2");
            DGVNomina.Rows[filaIndex].Cells["OtrasDeducciones"].Value = nomina.OtrasDeducciones.ToString("C2");
        }

        private Nomina cargarNomina()
        {
            Nomina nomina = new();
            nomina.Empleado = empleadoSeleccionado;
            nomina.Fecha = dtpFecha.Value;
            nomina.FechaFin = dtpFechaFin.Value;
            if (int.TryParse(txtHora.Text, out int horaExtra))
                nomina.HoraExtra = horaExtra;

            if (empleadoSeleccionado.IDHorario == (int)Horario.idNocturno || empleadoSeleccionado.IDHorario == (int)Horario.idMixto)
                nomina.Nocturnidad = nomina.CalcularNocturnidad();
            else
            {
                MessageBox.Show("No se le aplica nocturnidad", "No se aplica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomina.Nocturnidad = 0;
            }
            if (empleadoSeleccionado.IDCargo != null)
            {
                CargoController cargoController = new CargoController();
                Cargo cargo = cargoController.ObtenerCargoPorId(empleadoSeleccionado.IDCargo);

                if (cargo != null)
                {
                    if (cargo.AplicaComisiones)
                    {
                        decimal porcentajeComision = 0;
                        decimal venta = 0;

                        if (decimal.TryParse(txtPorcentaje.Text, out porcentajeComision) &&
                            decimal.TryParse(txtVenta.Text, out venta))
                        {
                            decimal porcentajeComi = venta * porcentajeComision;
                            nomina.Comisiones = porcentajeComi;
                        }
                    }
                    else
                    {
                        nomina.Comisiones = 0;
                        MessageBox.Show("No se le aplica comisiones", "No se aplica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (cargo.AplicaRiesgoLaboral)
                    {
                        nomina.RiesgoLaboral = nomina.CalcularRiesgoLaboral();
                    }
                    else
                    {
                        nomina.RiesgoLaboral = 0;
                        MessageBox.Show("No se le aplica Riesgo laboral", "No se aplica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (decimal.TryParse(txtViaticoAlimentacion.Text, out decimal ViaticoAliementacion))
                    nomina.ViaticoAlimentacion = ViaticoAliementacion;
                if (decimal.TryParse(txtViaticoTransporte.Text, out decimal ViaticoTransporte))
                    nomina.ViaticoTransporte = ViaticoTransporte;
                if (decimal.TryParse(txtDeprecVehiculo.Text, out decimal deprecV))
                    nomina.DepreciacionVehiculo = deprecV;
                if (decimal.TryParse(txtPrestamos.Text, out decimal prestamos))
                    nomina.Prestamos = prestamos;
                nomina.INSS = nomina.CalcularINSS();
                if (decimal.TryParse(txtEmbargos.Text, out decimal embargos))
                    nomina.Embargos = embargos;

                nomina.Antiguedad = nomina.calcularAntiguedad();
                nomina.SalarioNeto = nomina.CalcularSalarioNeto();
                nomina.SalarioPorDia = nomina.CalcularSalarioPorDia();
                nomina.SalarioQuincenal = nomina.calcularSalarioQuincenal();
                nomina.IngresoAguinaldo = nomina.MostrarAguinaldoAcmulado();
                nomina.IngresoVacaciones = nomina.MostrarVacacionesAcumuladas();
                nomina.Indemizacion = nomina.calcularPagoIndenmizacion();
                nomina.OtrosIngresos = Convert.ToDecimal(txtOtrosIngresos.Text);
                nomina.OtrasDeducciones = Convert.ToDecimal(txtOtrasDeducciones.Text);
            }
            return nomina;
        }


        private void btnSeleccionEmp_Click(object sender, EventArgs e)
        {
            if (lvEmpleados.SelectedItems.Count > 0)
            {
                if (int.TryParse(lvEmpleados.SelectedItems[0].SubItems[0].Text, out int empleadoID))
                {
                    empleadoSeleccionado = listaEmpleados.FirstOrDefault(empleado => empleado.IDEmpleado == empleadoID);
                    if (empleadoSeleccionado != null)
                    {
                        MessageBox.Show("Empleado seleccionado: " + empleadoSeleccionado.PrimerNombre + " " + empleadoSeleccionado.PrimerApellido, "Empleado Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ComisionesController comisionesController = new ComisionesController();
                        List<string> valoresMeta = comisionesController.ObtenerMetaVentas(empleadoSeleccionado.IDCargo);
                        cmbMetaVenta.Items.Clear();
                        cmbMetaVenta.Items.AddRange(valoresMeta.ToArray());
                        CargarComboBoxMeta();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado antes de continuar.", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMetaVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetaVenta.SelectedItem != null)
            {
                string metaVentas = cmbMetaVenta.SelectedItem.ToString();
                ComisionesController comisionesController = new ComisionesController();
                decimal porcentajeComision = comisionesController.ObtenerPorcentajeSegunMeta(metaVentas);

                if (porcentajeComision > 0)
                {
                    txtPorcentaje.Text = porcentajeComision.ToString();
                }
                else
                {
                    txtPorcentaje.Text = "Porcentaje no encontrado";
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (DGVNomina.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo de Excel (*.xlsx)|*.xlsx",
                FileName = "Planilla.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Planilla");

                    worksheet.Cells["A1"].Value = "Planilla";
                    worksheet.Cells["A1:H1"].Merge = true;
                    worksheet.Cells["A1:H1"].Style.Font.Size = 18;
                    worksheet.Cells["A1:H1"].Style.Font.Bold = true;
                    worksheet.Cells["A1:H1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    for (int i = 1; i <= DGVNomina.Columns.Count; i++)
                    {
                        worksheet.Cells[2, i].Value = DGVNomina.Columns[i - 1].HeaderText;
                        worksheet.Cells[2, i].Style.Font.Bold = true;
                        worksheet.Cells[2, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[2, i].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                    }
                    for (int i = 0; i < DGVNomina.Rows.Count; i++)
                    {
                        for (int j = 0; j < DGVNomina.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 3, j + 1].Value = DGVNomina.Rows[i].Cells[j].Value;
                        }
                    }

                    package.SaveAs(new FileInfo(saveFileDialog.FileName));
                }

                MessageBox.Show("Los datos se han exportado exitosamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPorcentaje.Clear();
            txtVenta.Clear();
            txtHora.Clear();
            txtViaticoAlimentacion.Clear();
            txtViaticoTransporte.Clear();
            txtDeprecVehiculo.Clear();
            txtPrestamos.Clear();
            txtEmbargos.Clear();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                tabNomina.Enabled = true;

            if (RBMensual.Checked || RBQuincenal.Checked)
                tabNomina.Enabled = true;
            else
            {
                MessageBox.Show("Seleccione un modo de calculo de la nomina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarComboBoxMeta();

        }

    }
}