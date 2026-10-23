
using AccesoDatos.Models;
using AccesoDatos.Repositories;
using System;
using System.Net.Mail;

namespace TiendaRopaApp
{
    public partial class FormClientes : Form
    {
        private GenericRepository<Cliente> repositorio =
            new GenericRepository<Cliente>();

        private int idClienteSeleccionado = 0;

        public FormClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = repositorio.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "" ||
                txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            try
            {
                MailAddress correo = new MailAddress(txtEmail.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresá un correo electrónico válido.");
                return;
            }

            Cliente cliente = new Cliente();

            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellido = txtApellido.Text.Trim();
            cliente.Email = txtEmail.Text.Trim();
            cliente.Telefono = txtTelefono.Text.Trim();
            cliente.Direccion = txtDireccion.Text.Trim();
            cliente.Estado = true;

            repositorio.Agregar(cliente);

            MessageBox.Show("Cliente agregado correctamente.");

            CargarClientes();
            LimpiarCampos();
        }

        private void dgvClientes_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idClienteSeleccionado = Convert.ToInt32(
                    dgvClientes.Rows[e.RowIndex].Cells["Id"].Value);

                txtNombre.Text = dgvClientes.Rows[e.RowIndex]
                    .Cells["Nombre"].Value?.ToString() ?? "";

                txtApellido.Text = dgvClientes.Rows[e.RowIndex]
                    .Cells["Apellido"].Value?.ToString() ?? "";

                txtEmail.Text = dgvClientes.Rows[e.RowIndex]
                    .Cells["Email"].Value?.ToString() ?? "";

                txtTelefono.Text = dgvClientes.Rows[e.RowIndex]
                    .Cells["Telefono"].Value?.ToString() ?? "";

                txtDireccion.Text = dgvClientes.Rows[e.RowIndex]
                    .Cells["Direccion"].Value?.ToString() ?? "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un cliente de la tabla.");
                return;
            }

            if (txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "" ||
                txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            try
            {
                MailAddress correo = new MailAddress(txtEmail.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresá un correo electrónico válido.");
                return;
            }

            Cliente cliente = new Cliente();

            cliente.Id = idClienteSeleccionado;
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellido = txtApellido.Text.Trim();
            cliente.Email = txtEmail.Text.Trim();
            cliente.Telefono = txtTelefono.Text.Trim();
            cliente.Direccion = txtDireccion.Text.Trim();
            cliente.Estado = true;

            repositorio.Modificar(cliente);

            MessageBox.Show("Cliente modificado correctamente.");

            CargarClientes();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un cliente de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás segura de que querés eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                repositorio.Eliminar(idClienteSeleccionado);

                MessageBox.Show("Cliente eliminado correctamente.");

                CargarClientes();
                LimpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se puede eliminar este cliente porque puede tener ventas asociadas.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idClienteSeleccionado = 0;

            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            dgvClientes.ClearSelection();
        }
    }
}
