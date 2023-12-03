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
using Modelo;
using Controladores;

namespace UINomina
{
    public partial class FrmEditarCargo : Form
    {
        public int idCargo { get; set; }
        public FrmEditarCargo()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void FrmEditarCargo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmEditarCargo_Load(object sender, EventArgs e)
        {
            CargoController cargoController = new CargoController();
            Cargo cargo = new Cargo();
            cargo = cargoController.ObtenerCargoPorId(idCargo);

            if (cargo != null)
            {
                txtCargo.Text = cargo.Nombre;
                if (cargo.AplicaComisiones == true)
                {
                    RBTrueComisiones.Checked = true;
                    RBFalseComisiones.Checked = false;

                }
                else if (cargo.AplicaComisiones == false)
                {
                    RBTrueComisiones.Checked = false;
                    RBFalseComisiones.Checked = true;

                }
                if (cargo.AplicaRiesgoLaboral == true)
                {
                    RBTrueRiesgoLaboral.Checked = true;
                    RBFalseRiesgoLaboral.Checked = false;

                }
                else if (cargo.AplicaRiesgoLaboral == false)
                {
                    RBTrueRiesgoLaboral.Checked = false;
                    RBFalseRiesgoLaboral.Checked = true;

                }
            }


        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cargo cargo = new();
            CargoController cargoController = new();
            cargo.IDCargo = idCargo;
            cargo.Nombre = txtCargo.Text;
            if (RBTrueComisiones.Checked)
                cargo.AplicaComisiones = true;

            else if (RBFalseComisiones.Checked)
                cargo.AplicaComisiones = false;

            if (RBTrueRiesgoLaboral.Checked)
                cargo.AplicaRiesgoLaboral = true;

            else if (RBFalseRiesgoLaboral.Checked)
                cargo.AplicaRiesgoLaboral = false;

            List<string> errores = Validation.ValidarModelo(cargo);
            if (errores.Count == 0)
            {
                try
                {
                    cargoController.ActualizarCargo(cargo);
                    MessageBox.Show("Cargo Actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el Cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
