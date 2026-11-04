
using AccesoDatos.Models;
using AccesoDatos.Repositories;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TiendaRopaApp
{
    public partial class FormVendedores : Form
    {
        private readonly IGenericRepository<Vendedor> repositorio;

        private int idVendedorSeleccionado = 0;

        public FormVendedores(IGenericRepository<Vendedor> repositorio)
        {
            InitializeComponent();

            this.repositorio = repositorio;

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            CargarVendedores();
        }

        private void CargarVendedores()
        {
            dgvVendedores.DataSource = null;
            dgvVendedores.DataSource = repositorio.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            if (!ValidarTelefono(txtTelefono.Text.Trim()))
            {
                MessageBox.Show(
                    "Ingresá un teléfono válido. Debe contener entre 8 y 15 números.");
                return;
            }

            Vendedor vendedor = new Vendedor();
            vendedor.Nombre = txtNombre.Text.Trim();
            vendedor.Apellido = txtApellido.Text.Trim();
            vendedor.Telefono = txtTelefono.Text.Trim();
            vendedor.Estado = true;

            repositorio.Agregar(vendedor);

            MessageBox.Show("Vendedor agregado correctamente.");
            CargarVendedores();
            LimpiarCampos();
        }

        private void dgvVendedores_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idVendedorSeleccionado = Convert.ToInt32(
                    dgvVendedores.Rows[e.RowIndex].Cells["Id"].Value);

                txtNombre.Text = dgvVendedores.Rows[e.RowIndex]
                    .Cells["Nombre"].Value?.ToString() ?? "";

                txtApellido.Text = dgvVendedores.Rows[e.RowIndex]
                    .Cells["Apellido"].Value?.ToString() ?? "";

                txtTelefono.Text = dgvVendedores.Rows[e.RowIndex]
                    .Cells["Telefono"].Value?.ToString() ?? "";

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private bool ValidarTelefono(string telefono)
        {
            if (!Regex.IsMatch(telefono, @"^\+?[0-9][0-9\s()-]*[0-9]$"))
            {
                return false;
            }

            string numeros = new string(
                telefono.Where(char.IsDigit).ToArray());

            if (numeros.Length < 8 || numeros.Length > 15)
            {
                return false;
            }

            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idVendedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un vendedor de la tabla.");
                return;
            }

            if (txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            if (!ValidarTelefono(txtTelefono.Text.Trim()))
            {
                MessageBox.Show(
                    "Ingresá un teléfono válido. Debe contener entre 8 y 15 números.");
                return;
            }

            Vendedor vendedor = new Vendedor();
            vendedor.Id = idVendedorSeleccionado;
            vendedor.Nombre = txtNombre.Text.Trim();
            vendedor.Apellido = txtApellido.Text.Trim();
            vendedor.Telefono = txtTelefono.Text.Trim();
            vendedor.Estado = true;

            repositorio.Modificar(vendedor);

            MessageBox.Show("Vendedor modificado correctamente.");
            CargarVendedores();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idVendedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un vendedor de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás segura de que querés eliminar este vendedor?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                return;

            try
            {
                repositorio.Eliminar(idVendedorSeleccionado);

                MessageBox.Show("Vendedor eliminado correctamente.");
                CargarVendedores();
                LimpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se puede eliminar este vendedor porque puede tener ventas asociadas.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idVendedorSeleccionado = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            dgvVendedores.ClearSelection();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}

