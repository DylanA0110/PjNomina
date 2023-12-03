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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UINomina
{
    public partial class FrmComisiones : Form
    {
        ComisionesController comisionController = new ComisionesController();
        public FrmComisiones()
        {
            InitializeComponent();
        }

        private void FrmComisiones_Load(object sender, EventArgs e)
        {
            LlenarComboBoxs();
            CargarComboCargo();
            CargarListView();
        }

        private void LlenarComboBoxs()
        {
            List<string> porcentajesMetaVentas = Enumerable.Range(1, 100)
                .Select(i => i + "%")
                .ToList();

            List<string> porcentajesComisiones = Enumerable.Range(1, 100)
                .Select(i => i + "%")
                .ToList();

            cmbMetaventas.DataSource = porcentajesMetaVentas;
            cmbPorcentajeComisiones.DataSource = porcentajesComisiones;
        }

        private void CargarComboCargo()
        {
            CargoController cargoController = new CargoController();
            List<Cargo> cargos = cargoController.ObtenerCargos();

            List<Cargo> cargosConComisiones = cargos.Where(cargo => cargo.AplicaComisiones).ToList();

            foreach (Cargo cargo in cargosConComisiones)
            {
                cmbCargo.Items.Add(cargo.Nombre);
            }

            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmbCargo.Items.Count > 0)
            {
                cmbCargo.SelectedIndex = 0;  
            }
        }
        private void CargarListView()
        {
            lvComisiones.Items.Clear();

            // Llama a ObtenerComisiones desde tu controlador para obtener los datos
            List<Comisiones> comisiones = comisionController.ObtenerComisiones();

            if (comisiones != null)
            {
                foreach (var comision in comisiones)
                {
                    ListViewItem item = new ListViewItem(comision.ID.ToString());
                    string nombreCargo = ObtenerNombreCargoPorId(comision.IDCargo);
                    item.SubItems.Add(nombreCargo);
                    item.SubItems.Add(comision.MetaVentas);
                    item.SubItems.Add(comision.PorcentajeComision.ToString());
                    lvComisiones.Items.Add(item);
                }
            }
        }

        private int ObtenerIdCargoPorNombre(string nombreCargo)
        {
            CargoController cargoController = new CargoController();
            Cargo cargo = cargoController.ObtenerCargos().FirstOrDefault(c => c.Nombre == nombreCargo);

            if (cargo != null)
            {
                return cargo.IDCargo;
            }

            return 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbCargo.SelectedItem == null || string.IsNullOrEmpty(cmbCargo.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione un cargo válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbMetaventas.SelectedItem == null || string.IsNullOrEmpty(cmbMetaventas.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione una meta de ventas válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbPorcentajeComisiones.SelectedItem == null || string.IsNullOrEmpty(cmbPorcentajeComisiones.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione un porcentaje de comisiones válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Comisiones comisiones = obtenerDatosFormulario();
            ComisionesController comisionesController = new();
            List<string> errores = Validation.ValidarModelo(comisiones);

            if (comisionesController.ComisionYaExiste(comisiones.IDCargo, (string)cmbMetaventas.SelectedItem))
            {
                MessageBox.Show("Esta comisión ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (errores.Count > 0)
            {
                try
                {
                    comisionesController.InsertarComision(comisiones);
                    MessageBox.Show("Comisión insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar la comisión " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private Comisiones obtenerDatosFormulario()
        {
            Comisiones comision = new();
            if (cmbCargo.SelectedItem != null && !string.IsNullOrEmpty(cmbCargo.SelectedItem.ToString()) &&
                cmbMetaventas.SelectedItem != null && !string.IsNullOrEmpty(cmbMetaventas.SelectedItem.ToString()) &&
                cmbPorcentajeComisiones.SelectedItem != null && !string.IsNullOrEmpty(cmbPorcentajeComisiones.SelectedItem.ToString()))
            {
                string cargoSeleccionado = (string)cmbCargo.SelectedItem;
                int idCargo = ObtenerIdCargoPorNombre(cargoSeleccionado);

                string porcentajeString = ((string)cmbPorcentajeComisiones.SelectedItem);
                porcentajeString = porcentajeString.TrimEnd('%');
                decimal porcentaje;
                if (decimal.TryParse(porcentajeString, out porcentaje))
                {
                    porcentaje /= 100.0m;
                }

                comision.IDCargo = idCargo;
                comision.PorcentajeComision = porcentaje;
                comision.MetaVentas = (string)cmbMetaventas.SelectedItem;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione valores válidos en todos los ComboBox.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return comision;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvComisiones.SelectedItems.Count > 0)
            {
                if (int.TryParse(lvComisiones.SelectedItems[0].SubItems[0].Text, out int ID))
                {
                    FrmEditarComision frmEditarComision = new();
                    frmEditarComision.idSQL = ID;
                    frmEditarComision.ShowDialog();
                }
            }
            else
                MessageBox.Show("Por favor, selecciona una fila antes de editar.", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ComisionesController comisionesController = new();
            if (lvComisiones.SelectedItems.Count > 0)
            {
                if (int.TryParse(lvComisiones.SelectedItems[0].SubItems[0].Text, out int ComisionID))
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este comision?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        comisionesController.EliminarCargo(ComisionID);
                        CargarListView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de eliminar.", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



