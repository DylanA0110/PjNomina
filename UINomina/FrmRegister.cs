using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Modelo;
using Controladores;

namespace UINomina
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmRegister_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtPrimerNombre_Enter(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "Primer nombre")
            {
                txtPrimerNombre.Text = "";
                txtPrimerNombre.ForeColor = Color.White;
            }
        }

        private void txtPrimerNombre_Leave(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "")
            {
                txtPrimerNombre.Text = "Primer nombre";
                txtPrimerNombre.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtSegundoNombre_Enter(object sender, EventArgs e)
        {
            if (txtSegundoNombre.Text == "Segundo nombre")
            {
                txtSegundoNombre.Text = "";
                txtSegundoNombre.ForeColor = Color.White;
            }
        }

        private void txtSegundoNombre_Leave(object sender, EventArgs e)
        {
            if (txtSegundoNombre.Text == "")
            {
                txtSegundoNombre.Text = "Segundo nombre";
                txtSegundoNombre.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPrimerApellido_Enter(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "Primer apellido")
            {
                txtPrimerApellido.Text = "";
                txtPrimerApellido.ForeColor = Color.White;
            }
        }

        private void txtPrimerApellido_Leave(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "")
            {
                txtPrimerApellido.Text = "Primer apellido";
                txtPrimerApellido.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtSegundoApellido_Enter(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "Segundo apellido")
            {
                txtSegundoApellido.Text = "";
                txtSegundoApellido.ForeColor = Color.White;
            }
        }

        private void txtSegundoApellido_Leave(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "")
            {
                txtSegundoApellido.Text = "Segundo apellido";
                txtSegundoApellido.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo electronico")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo electronico";
                txtCorreo.ForeColor = Color.WhiteSmoke;
            }

        }

        private void txtUserRegist_Enter(object sender, EventArgs e)
        {
            if (txtUserRegist.Text == "Usuario")
            {
                txtUserRegist.Text = "";
                txtUserRegist.ForeColor = Color.White;
            }
        }

        private void txtUserRegist_Leave(object sender, EventArgs e)
        {
            if (txtUserRegist.Text == "")
            {
                txtUserRegist.Text = "Usuario";
                txtUserRegist.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtConfirmPass_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "Repetir contraseña")
            {
                txtConfirmPass.Text = "";
                txtConfirmPass.ForeColor = Color.White;
            }
        }

        private void txtConfirmPass_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "")
            {
                txtConfirmPass.Text = "Repetir contraseña";
                txtConfirmPass.ForeColor = Color.WhiteSmoke;
            }
        }
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.White;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.WhiteSmoke;
            }
        }
        private void btnRegsitrar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = ObtenerDatosDeFormulario();
            UsuarioController usuarioController = new();
            List<string> errores = Validation.ValidarModelo(nuevoUsuario);
            if (errores.Count == 0)
            {
                if (usuarioController.UsuarioExiste(nuevoUsuario.NombreUsuario))
                {
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    usuarioController.InsertarUsuario(nuevoUsuario);
                    MessageBox.Show("Usuario insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Usuario ObtenerDatosDeFormulario()
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtPrimerNombre.Text;
            usuario.SegundoNombre = txtSegundoNombre.Text;
            usuario.PrimerApellido = txtPrimerApellido.Text;
            usuario.SegundoApellido = txtSegundoApellido.Text;
            usuario.NombreUsuario = txtUserRegist.Text;
            if (txtConfirmPass.Text == txtPass.Text)
                usuario.Password = txtConfirmPass.Text;
            else
                MessageBox.Show("Las contraseñas no coinciden, por favor ingrese de nuevo la confirmacion de contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            usuario.CorreoElectronico = txtCorreo.Text;
            usuario.FechaNac = dtpFechaNac.Value;
            usuario.IdRol = (int)Rol.IdAsistenteContable;
            usuario.Telefono = txtTelefono.Text;
            return usuario;
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            dtpFechaNac.Format = DateTimePickerFormat.Custom;
            dtpFechaNac.CustomFormat = "dd/MM/yyyy";
            dtpFechaNac.ShowUpDown = true;

        }

    }
}
