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
    public partial class FrmLogin : Form
    {
        private int intentosFallidos = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;

            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.WhiteSmoke;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmregist = new FrmRegister();
            frmregist.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UsuarioController userControl = new();
            user.NombreUsuario = txtUser.Text;
            user.Password = txtPass.Text;

            if (userControl.Login(user))
            {
                Usuario usuarioAutenticado = userControl.SelectUserPorNombreUsuario(user.NombreUsuario);
                userControl.ActualizarUltimoAcceso(user);
                FrmPrincipal frmMain = new FrmPrincipal(usuarioAutenticado.ID);
                UsuarioAutentificado.id = usuarioAutenticado.ID;
                frmMain.Show();
                this.Hide();
            }
            else
            {
                intentosFallidos++;
                MessageBox.Show("Nombre usuario o contraseña incorrecta, intente de nuevo", "Error al iniciar session", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validation.ContadorIntentos(intentosFallidos))
                {
                    MessageBox.Show("Has excedido el numero maximo de intentos. El programa se cerrara.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion.CrearBaseDeDatosYTablaSiNoExisten();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la base de datos y la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
