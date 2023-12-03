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
using Controladores;
using Modelo;
using Microsoft.VisualBasic.ApplicationServices;

namespace UINomina
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(int idUser2)
        {
            InitializeComponent();
            AbrirFormHija(new FrmHome());
            UsuarioController userController = new UsuarioController();
            Usuario user = userController.SelectUserPorID(idUser2);

            if (user != null)
            {
                lbNombres.Text = $"{user.Nombre} {user.PrimerApellido}";
                if (user.IdRol == (int)Rol.IdAdministrador)
                    lbRol.Text = "Adminsitrador";
                else if (user.IdRol == (int)Rol.IdGerente)
                    lbRol.Text = "Gerente";
                else if (user.IdRol == (int)Rol.IdContadorGeneral)
                    lbRol.Text = "Contador General";
                else
                    lbRol.Text = "Asistente Contable";

                int verticalPosition = (panel5.Height - lbNombres.Height - lbRol.Height) / 2;

                lbNombres.Top = verticalPosition;
                lbRol.Top = lbNombres.Bottom;

            }

        }
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
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

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new();
            login.Show();
            this.Hide();
        }
        private void AbrirFormHija(object formulario)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.MouseDown += FrmPrincipal_MouseDown;
            fh.Controls.Add(PBCerrar);
            fh.Controls.Add(PBMinimizar);
            PBCerrar.Visible = true;
            PBMinimizar.Visible = true;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FrmConfiguraciones frmConfig = new FrmConfiguraciones();
            AbrirFormHija(frmConfig);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome frmhome = new FrmHome();
            AbrirFormHija(frmhome);

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            UsuarioController US = new();
            Usuario user = new();
            user = US.SelectUserPorID(UsuarioAutentificado.id);
            if (user.IdRol == (int)Rol.IdAdministrador || user.IdRol == (int)Rol.IdGerente || user.IdRol == (int)Rol.IdContadorGeneral)
                subMenuEmpleado.Visible = true;
            else
                MessageBox.Show("No tiene suficiente permiso para administrar empleados", "Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            subMenuEmpleado.Visible = false;
            FrmAgregarEmpleado frmAggEmp = new();
            PBCerrar.Visible = false;
            PBMinimizar.Visible = false;
            AbrirFormHija(frmAggEmp);

        }

        private void btnAdminEmp_Click(object sender, EventArgs e)
        {
            subMenuEmpleado.Visible = false;
        }

        private void btnAggCargo_Click(object sender, EventArgs e)
        {
            subMenuEmpleado.Visible = false;
            FrmAgregarCargo frmAC = new();
            AbrirFormHija(frmAC);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            subMenuEmpleado.Visible = false;
            FrmHome frmhome = new FrmHome();
            AbrirFormHija(frmhome);
        }

        private void PBCerrar_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEmpleadosNoActivos_Click(object sender, EventArgs e)
        {
            subMenuEmpleado.Visible = false;
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            UsuarioController US = new();
            Usuario user = new();
            user = US.SelectUserPorID(UsuarioAutentificado.id);
            if (user.IdRol== (int)Rol.IdAdministrador || user.IdRol == (int)Rol.IdGerente)
            { 
                FrmComisiones frmComisiones = new();
                AbrirFormHija(frmComisiones);
                PBCerrar.Visible = false;
                PBMinimizar.Visible = false;
            }
            else
                MessageBox.Show("No tiene suficiente permiso para administrar las comisiones", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            FrmPlanilla frmPlanilla = new();
            PBCerrar.Visible = false;
            PBMinimizar.Visible = false;
            AbrirFormHija(frmPlanilla);
        }
    }
}
