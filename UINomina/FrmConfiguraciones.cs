using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using Controladores;
using Modelo;

namespace UINomina
{
    public partial class FrmConfiguraciones : Form
    {
        public FrmConfiguraciones()
        {
            InitializeComponent();
        }

        private void Esconder_Click(object sender, EventArgs e)
        {
            Esconder.Visible = false;
            Ver.Visible = true;
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            Ver.Visible = false;
            Esconder.Visible = true;
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void FrmConfiguraciones_Load(object sender, EventArgs e)
        {
            Usuario user = new();
            UsuarioController US = new();
            int ID = (int)UsuarioAutentificado.id;
            user = US.SelectUserPorID(ID);
            List<Usuario> ListaUsuarios = US.TraerUsuarios().ToList();

            if (ListaUsuarios != null)
            {
                foreach (var usuario in ListaUsuarios)
                {
                    ListViewItem item = new ListViewItem(usuario.ID.ToString());

                    item.SubItems.Add(usuario.Nombre);
                    item.SubItems.Add(usuario.SegundoNombre);
                    item.SubItems.Add(usuario.PrimerApellido);
                    item.SubItems.Add(usuario.SegundoApellido);
                    item.SubItems.Add(usuario.NombreUsuario);
                    item.SubItems.Add(usuario.CorreoElectronico);
                    item.SubItems.Add(usuario.FechaNac.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(usuario.FechaRegistro.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(usuario.UltimoAcceso.ToString());
                    if (usuario.IdRol == (int)Rol.IdAdministrador)
                        item.SubItems.Add("Administrador");
                    else if (usuario.IdRol == (int)Rol.IdGerente)
                        item.SubItems.Add("Gerente");
                    else if (usuario.IdRol == (int)Rol.IdContadorGeneral)
                        item.SubItems.Add("Contador General");
                    else if (usuario.IdRol == (int)Rol.IdAsistenteContable)
                        item.SubItems.Add("Asistente Contable");
                    else
                        item.SubItems.Add("Otro Rol");

                    item.SubItems.Add(usuario.Telefono);

                    lstUsuarios.Items.Add(item);
                }
            }
            if (user != null)
            {
                txtNombre.Text = user.Nombre;
                txtSegundoNombre.Text = user.SegundoNombre;
                txtApellido.Text = user.PrimerApellido;
                txtSegundoApellido.Text = user.SegundoApellido;
                txtContraseña.Text = user.Password;
                txtUser.Text = user.NombreUsuario;
                txtCorreo.Text = user.CorreoElectronico;
                string formato = "dd/MM/yyyy";
                string fechaNacimientoTexto = user.FechaNac.ToString(formato);
                txtFechaNacimiento.Text = fechaNacimientoTexto;
                txtTelefono.Text = user.Telefono;
                if (user.IdRol == (int)Rol.IdAdministrador)
                    txtRol.Text = "Administrador";
                else if (user.IdRol == (int)Rol.IdGerente)
                    txtRol.Text = "Gerente";
                else if (user.IdRol == (int)Rol.IdContadorGeneral)
                    txtRol.Text = "Contador General";
                else if (user.IdRol == (int)Rol.IdAsistenteContable)
                    txtRol.Text = "Asistente Contable";

                if (user.IdRol == (int)Rol.IdAdministrador || user.IdRol == (int)Rol.IdGerente)
                {
                    lstUsuarios.Visible = true;
                    btnEditarUsuarios.Visible = true;
                    lbTituloEdit.Visible = true;
                    lstUsuarios.FullRowSelect = true;
                }
            }
            else
            {
                MessageBox.Show("Usuario nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario ediUser = new(false);
            ediUser.ShowDialog();
        }

        private void btnEditarUsuarios_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItems.Count > 0)
            {
                if (int.TryParse(lstUsuarios.SelectedItems[0].SubItems[0].Text, out int userId))
                {
                    Usuario user = new();
                    UsuarioController US = new();
                    UsuarioAutentificado.idEdit = userId;
                    user = US.SelectUserPorID(UsuarioAutentificado.idEdit);
                    FrmEditarUsuario ediUser = new(true);
                    ediUser.ShowDialog();

                }
                else
                    MessageBox.Show("El ID seleccionado no es un número válido.");
            }
            else
                MessageBox.Show("Por favor, selecciona una fila antes de editar.", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
