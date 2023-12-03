using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelo;

namespace UINomina
{
    public partial class FrmAgregarCargo : Form
    {
        CargoController cargoController = null;
        List<Cargo> listaCargos = null;
        public FrmAgregarCargo()
        {
            InitializeComponent();
        }

        private void txtCargo_Enter(object sender, EventArgs e)
        {
            if (txtCargo.Text == "Nombre de cargo")
                txtCargo.Text = "";
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            if (txtCargo.Text == "")
                txtCargo.Text = "Nombre de cargo";
        }

        private void lvCargos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.BackColor = Color.FromArgb(96, 60, 220);
            }
            else
            {
                e.Item.BackColor = lvCargos.BackColor;
            }
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            Cargo cargo = ObtenerDatosFormulario();
            cargoController = new();
            List<string> errores = Validation.ValidarModelo(cargo);

            if (!RBTrueComisiones.Checked && !RBFalseComisiones.Checked)
            {
                MessageBox.Show("Debes seleccionar si el cargo se le aplican comisiones.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!RBTrueRiesgoLaboral.Checked && !RBFalseRiesgoLaboral.Checked)
            {
                MessageBox.Show("Debes seleccionar si el cargo se le aplica Riesgo Laboral.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (errores.Count == 0)
            {
                if (cargoController.CargoExiste(cargo.Nombre))
                {
                    MessageBox.Show("El nombre del cargo ya existe. Por favor, elija otro nombre de cargo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    cargoController.InsertarCargo(cargo);
                    MessageBox.Show("Cargo insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Cargo ObtenerDatosFormulario()
        {
            Cargo cargo = new();
            cargo.Nombre = txtCargo.Text;
            if (RBTrueComisiones.Checked)
                cargo.AplicaComisiones = true;

            else if (RBFalseComisiones.Checked)
                cargo.AplicaComisiones = false;

            if (RBTrueRiesgoLaboral.Checked)
                cargo.AplicaRiesgoLaboral = true;

            else if (RBFalseRiesgoLaboral.Checked)
                cargo.AplicaRiesgoLaboral = false;
            return cargo;
        }

        private void FrmAgregarCargo_Load(object sender, EventArgs e)
        {
            cargoController = new();
            lvCargos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listaCargos = cargoController.ObtenerCargos();

            CargarListView();
        }
        private void CargarListView(List<Cargo> cargos = null)
        {
            lvCargos.Items.Clear();
            List<Cargo> cargosToShow = cargos ?? listaCargos;

            if (cargosToShow != null)
            {
                foreach (var cargo in cargosToShow)
                {
                    ListViewItem item = new ListViewItem(cargo.IDCargo.ToString());
                    item.SubItems.Add(cargo.Nombre);
                    item.SubItems.Add(cargo.AplicaComisiones ? "Se aplica" : "No se aplica");
                    item.SubItems.Add(cargo.AplicaRiesgoLaboral ? "Se aplica" : "No se aplica");
                    lvCargos.Items.Add(item);
                }
            }
        }


        private void btnEditarCargo_Click(object sender, EventArgs e)
        {
            if (lvCargos.SelectedItems.Count > 0)
            {
                if (int.TryParse(lvCargos.SelectedItems[0].SubItems[0].Text, out int cargoID))
                {
                    FrmEditarCargo frmEditarCargo = new FrmEditarCargo();
                    frmEditarCargo.idCargo = cargoID;
                    frmEditarCargo.ShowDialog();
                }
            }
            else
                MessageBox.Show("Por favor, selecciona una fila antes de editar.", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminarCargo_Click(object sender, EventArgs e)
        {
            cargoController = new();
            if (lvCargos.SelectedItems.Count > 0)
            {
                if (int.TryParse(lvCargos.SelectedItems[0].SubItems[0].Text, out int cargoID))
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cargo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        cargoController.EliminarCargo(cargoID);
                        CargarListView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de eliminar.", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBusqueda.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusqueda) && listaCargos != null)
            {
                List<Cargo> cargosFiltrados = listaCargos
                    .Where(cargo => cargo.Nombre.Contains(textoBusqueda, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (cargosFiltrados.Count > 0)
                {
                    CargarListView(cargosFiltrados);
                }
                else
                {
                    MessageBox.Show("No se encontraron cargos que coincidan con la búsqueda.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                CargarListView();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            CargarListView();
        }
    }
}
