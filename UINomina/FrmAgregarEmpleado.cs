using Controladores;
using Modelo;
using System;
using System.Collections;
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
    public partial class FrmAgregarEmpleado : Form
    {
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void txtPrimerNombre_Enter(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "Primer nombre")
                txtPrimerNombre.Text = "";
        }

        private void txtPrimerNombre_Leave(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "")
                txtPrimerNombre.Text = "Primer nombre";
        }

        private void txtSegundoNombre_Enter(object sender, EventArgs e)
        {
            if (txtSegundoNombre.Text == "Segundo nombre")
                txtSegundoNombre.Text = "";
        }

        private void txtSegundoNombre_Leave(object sender, EventArgs e)
        {
            if (txtSegundoNombre.Text == "")
                txtSegundoNombre.Text = "Segundo nombre";
        }

        private void txtPrimerApellido_Enter(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "Primer apellido")
                txtPrimerApellido.Text = "";
        }

        private void txtPrimerApellido_Leave(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "")
                txtPrimerApellido.Text = "Primer apellido";
        }

        private void txtSegundoApellido_Enter(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "Segundo apellido")
                txtSegundoApellido.Text = "";
        }

        private void txtSegundoApellido_Leave(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "")
                txtSegundoApellido.Text = "Segundo apellido";
        }

        private void txtNumeroCedula_Enter(object sender, EventArgs e)
        {
            if (txtNumeroCedula.Text == "Numero de cedula")
                txtNumeroCedula.Text = "";
        }

        private void txtNumeroCedula_Leave(object sender, EventArgs e)
        {
            if (txtNumeroCedula.Text == "")
                txtNumeroCedula.Text = "Numero de cedula";
        }

        private void txtNumeroINSS_Enter(object sender, EventArgs e)
        {
            if (txtNumeroINSS.Text == "Numero INSS")
                txtNumeroINSS.Text = "";
        }

        private void txtNumeroINSS_Leave(object sender, EventArgs e)
        {
            if (txtNumeroINSS.Text == "")
                txtNumeroINSS.Text = "Numero INSS";
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
                txtDireccion.Text = "";
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
                txtDireccion.Text = "Dirección";
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
                txtTelefono.Text = "";
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
                txtTelefono.Text = "Telefono";
        }

        private void txtCelular_Enter(object sender, EventArgs e)
        {
            if (txtCelular.Text == "Celular")
                txtCelular.Text = "";
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
                txtCelular.Text = "Celular";
        }

        private void txtSalarioBase_Enter(object sender, EventArgs e)
        {
            if (txtSalarioBase.Text == "Salario Base")
                txtSalarioBase.Text = "";
        }

        private void txtSalarioBase_Leave(object sender, EventArgs e)
        {
            if (txtSalarioBase.Text == "")
                txtSalarioBase.Text = "Salario Base";
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = ObtenerDatosDeFormulario();
            EmpeladoController empleadoController = new();
            List<string> errores = Validation.ValidarModelo(empleado);
            if (!RBHombre.Checked && !RBMujer.Checked && !RBOtro.Checked)
            {
                MessageBox.Show("Debes seleccionar el sexo del empleado.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (!RBCasado.Checked && !RBSoltero.Checked && !RBViudo.Checked)
            {
                MessageBox.Show("Debes seleccionar el estado civil del empleado.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (errores.Count == 0)
            {
                try
                {
                    empleadoController.InsertarEmpleado(empleado);
                    MessageBox.Show("Empleado insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el Empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Empleado ObtenerDatosDeFormulario()
        {
            Empleado emp = new();
            emp.PrimerNombre = txtPrimerNombre.Text;
            emp.SegundoNombre = txtSegundoNombre.Text;
            emp.PrimerApellido = txtPrimerApellido.Text;
            emp.SegundoApellido = txtSegundoApellido.Text;
            Validation.FormatearCedula(txtNumeroCedula.Text);
            emp.NumeroCedula = txtNumeroCedula.Text;
            Validation.FormatearNumeroINSS(txtNumeroINSS.Text);
            emp.NumeroINSS = txtNumeroINSS.Text;
            emp.NumeroRUC = txtNumeroCedula.Text;
            emp.FechaNacimiento = dtpFechaNac.Value;
            emp.FechaContratacion = dtpFechaContratacion.Value;
            emp.Direccion = txtDireccion.Text;
            emp.Telefono = txtTelefono.Text;
            emp.Celular = txtCelular.Text;
            decimal salario;
            if (decimal.TryParse(txtSalarioBase.Text, out salario))
            {
                emp.SalarioOrdinario = salario;
            }
            string cargoSeleccionado = (string)cmbCargo.SelectedItem;
            int idCargo = ObtenerIdCargoPorNombre(cargoSeleccionado);
            emp.IDCargo = idCargo;

            if (RBHombre.Checked)
                emp.Sexo = "Hombre";
            else if (RBMujer.Checked)
                emp.Sexo = "Mujer";
            else if (RBOtro.Checked)
                emp.Sexo = "Otro";

            if (RBCasado.Checked)
                emp.EstadoCivil = "Casado";
            else if (RBSoltero.Checked)
                emp.EstadoCivil = "Soltero";
            else if (RBViudo.Checked)
                emp.EstadoCivil = "Viudo";

            if (RBDiurno.Checked)
                emp.IDHorario = (int)Horario.idDiurno;
            else if (RBNocturno.Checked)
                emp.IDHorario = (int)Horario.idNocturno;
            else if (RBMixto.Checked)
                emp.IDHorario = (int)Horario.idMixto;

            return emp;
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

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            CargarComboCargo();
        }

        private bool seleccionInicial = true;

        private void CargarComboCargo()
        {
            CargoController cargoController = new CargoController();
            List<Cargo> cargos = cargoController.ObtenerCargos();

            cmbCargo.Items.Add("Seleccione");

            foreach (Cargo cargo in cargos)
            {
                cmbCargo.Items.Add(cargo.Nombre);
            }

            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.SelectedIndex = 0;

            cmbCargo.DropDown += (sender, e) =>
            {
                if (seleccionInicial)
                {
                    cmbCargo.Items.RemoveAt(0);
                    seleccionInicial = false;
                }
            };
        }


    }
}
