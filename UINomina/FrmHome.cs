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

namespace UINomina
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            UsuarioController US = new UsuarioController();
            Usuario user = new();
            user = US.SelectUserPorID(UsuarioAutentificado.id);
            if (user.IdRol == (int)Rol.IdAdministrador || user.IdRol == (int)Rol.IdGerente)
            {
                panelCantidades.Visible = true;
                EmpeladoController empeladoController = new EmpeladoController();
                lbCantidadUser.Text = US.CantidadUsuarios().ToString();
                lbCantidadEmp.Text = empeladoController.CantidadEmpleados().ToString();
            }
            else
                panelCantidades.Visible = false;
        }
    }
}
