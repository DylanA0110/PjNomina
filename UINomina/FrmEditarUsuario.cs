using Controladores;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Runtime.InteropServices;

namespace UINomina
{
    public partial class FrmEditarUsuario : Form
    {
        private int ID;
        private int IDC = UsuarioAutentificado.id;
        public FrmEditarUsuario(bool openedFromEditarButton)
        {
            InitializeComponent();
            ID = openedFromEditarButton ? UsuarioAutentificado.idEdit : UsuarioAutentificado.id;
        }

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            Usuario user = new();
            Usuario user2 = new();
            UsuarioController US = new();
            dtFecha.Format = DateTimePickerFormat.Custom;
            dtFecha.CustomFormat = "dd/MM/yyyy";
            dtFecha.ShowUpDown = true;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;

            user = US.SelectUserPorID(ID);
            user2 = US.SelectUserPorID(IDC);
            if (user != null)
            {
                txtNombre.Text = user.Nombre;
                txtSegundoNombre.Text = user.SegundoNombre;
                txtApellido.Text = user.PrimerApellido;
                txtSegundoApellido.Text = user.SegundoApellido;
                txtContraseña.Text = user.Password;
                txtConfirmPass.Text = user.Password;
                txtUser.Text = user.NombreUsuario;
                txtCorreo.Text = user.CorreoElectronico;
                dtFecha.Value = user.FechaNac;
                txtTelefono.Text = user.Telefono;
                if (user.IdRol == (int)Rol.IdAdministrador)
                {
                    cmbRol.SelectedItem = "Administrador";
                    txtRol.Text = "Administrador";
                }
                else if (user.IdRol == (int)Rol.IdGerente)
                {
                    cmbRol.SelectedItem = "Gerente";
                    txtRol.Text = "Gerente";
                }
                else if (user.IdRol == (int)Rol.IdContadorGeneral)
                {
                    cmbRol.SelectedItem = "Contador General";
                    txtRol.Text = "Contador General";
                }
                else if (user.IdRol == (int)Rol.IdAsistenteContable)
                {
                    cmbRol.SelectedItem = "Asistente Contable";
                    txtRol.Text = "Asistente Contable";
                }

                if (user2.IdRol == (int)Rol.IdAdministrador || user2.IdRol == (int)Rol.IdGerente)
                {
                    cmbRol.Visible = true;
                    txtRol.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Usuario nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new();
            Usuario nuevoUsuario = ObtenerDatosEditados();
            List<string> errores = Validation.ValidarModelo(nuevoUsuario);
            if (errores.Count == 0)
            {
                try
                {
                    usuarioController.ActualizarUsuario(nuevoUsuario);
                    MessageBox.Show("Usuario Actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Usuario ObtenerDatosEditados()
        {
            Usuario usuario = new Usuario();
            usuario.ID = ID;
            usuario.Nombre = txtNombre.Text;
            usuario.SegundoNombre = txtSegundoNombre.Text;
            usuario.PrimerApellido = txtApellido.Text;
            usuario.SegundoApellido = txtSegundoApellido.Text;
            usuario.NombreUsuario = txtUser.Text;
            if (txtConfirmPass.Text == txtContraseña.Text)
                usuario.Password = txtConfirmPass.Text;
            else
                MessageBox.Show("Las contraseñas no coinciden, por favor ingrese de nuevo la confirmacion de contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            usuario.CorreoElectronico = txtCorreo.Text;
            usuario.FechaNac = dtFecha.Value;
            usuario.Telefono = txtTelefono.Text;
            usuario.CorreoElectronico = txtCorreo.Text;
            string rolSeleccionado = cmbRol.SelectedItem.ToString();
            if (rolSeleccionado == "Administrador")
            {
                usuario.IdRol = (int)Rol.IdAdministrador;
            }
            else if (rolSeleccionado == "Gerente")
            {
                usuario.IdRol = (int)Rol.IdGerente;
            }
            else if (rolSeleccionado == "Contador General")
            {
                usuario.IdRol = (int)Rol.IdContadorGeneral;
            }
            else if (rolSeleccionado == "Asistente Contable")
            {
                usuario.IdRol = (int)Rol.IdAsistenteContable;
            }

            return usuario;
        }

        private void FrmEditarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtRol_Click(object sender, EventArgs e)
        {
            Usuario user = new();
            UsuarioController US = new();
            user = US.SelectUserPorID(IDC);
            

            if (user.IdRol != (int)Rol.IdAdministrador)
                MessageBox.Show("Para editar el rol, debe tener mayor rango", "No puede editar rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
