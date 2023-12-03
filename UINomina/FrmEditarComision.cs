using Controladores;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UINomina
{
    public partial class FrmEditarComision : Form
    {
        public int idSQL { get; set; }
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public FrmEditarComision()
        {
            InitializeComponent();
        }

        private void FrmEditarComision_Load(object sender, EventArgs e)
        {
            ComisionesController comisionesController = new ComisionesController();
            Comisiones comisiones = comisionesController.ObtenerComisionPorID(idSQL);
            LlenarComboBoxs();

            if (comisiones != null)
            {
                string nombreCargo = ObtenerNombreCargoPorId(comisiones.IDCargo);
                cmbCargo.Items.Add(nombreCargo);
                decimal porcentajeDecimal = comisiones.PorcentajeComision;
                int porcentajeNormal = (int)(porcentajeDecimal * 100);
                string porcentajeCadena = porcentajeNormal.ToString() + "%";
                cmbPorcentajeComisiones.SelectedItem = porcentajeCadena;
                cmbMetaventas.SelectedItem = comisiones.MetaVentas;
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
        private void PBCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmEditarComision_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
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

            if (errores.Count > 0)
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    comisionesController.ActualizarComision(comisiones);
                    MessageBox.Show("Comisión actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la comisión " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

                // Elimina el símbolo de porcentaje y convierte la cadena a decimal
                porcentajeString = porcentajeString.TrimEnd('%');
                decimal porcentaje;
                if (decimal.TryParse(porcentajeString, out porcentaje))
                {
                    porcentaje /= 100.0m; // Divide entre 100 para obtener el valor decimal
                }
                comision.ID = idSQL;
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
    }
}
