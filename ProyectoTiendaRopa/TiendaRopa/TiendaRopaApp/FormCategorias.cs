
using AccesoDatos.Models;
using AccesoDatos.Repositories;
using System;

namespace TiendaRopaApp
{
    public partial class FormCategorias : Form
    {
        private readonly IGenericRepository<Categoria> repositorio;

        private int idCategoriaSeleccionada = 0;

        public FormCategorias(IGenericRepository<Categoria> repositorio)
        {
            InitializeComponent();

            this.repositorio = repositorio;

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            CargarCategorias();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = repositorio.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            Categoria categoria = new Categoria();

            categoria.Nombre = txtNombre.Text.Trim();
            categoria.Descripcion = txtDescripcion.Text.Trim();
            categoria.Estado = true;

            repositorio.Agregar(categoria);

            MessageBox.Show("Categoría agregada correctamente.");

            CargarCategorias();
            LimpiarCampos();
        }

        private void dgvCategorias_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idCategoriaSeleccionada = Convert.ToInt32(
                    dgvCategorias.Rows[e.RowIndex].Cells["Id"].Value);

                txtNombre.Text = dgvCategorias.Rows[e.RowIndex]
                    .Cells["Nombre"].Value?.ToString() ?? "";

                txtDescripcion.Text = dgvCategorias.Rows[e.RowIndex]
                    .Cells["Descripcion"].Value?.ToString() ?? "";

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idCategoriaSeleccionada == 0)
            {
                MessageBox.Show("Seleccioná una categoría de la tabla.");
                return;
            }

            if (txtNombre.Text.Trim() == "" ||
                txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            Categoria categoria = new Categoria();

            categoria.Id = idCategoriaSeleccionada;
            categoria.Nombre = txtNombre.Text.Trim();
            categoria.Descripcion = txtDescripcion.Text.Trim();
            categoria.Estado = true;

            repositorio.Modificar(categoria);

            MessageBox.Show("Categoría modificada correctamente.");

            CargarCategorias();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idCategoriaSeleccionada == 0)
            {
                MessageBox.Show("Seleccioná una categoría de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás segura de que querés eliminar esta categoría?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                repositorio.Eliminar(idCategoriaSeleccionada);

                MessageBox.Show("Categoría eliminada correctamente.");

                CargarCategorias();
                LimpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se puede eliminar esta categoría porque puede estar asociada a productos.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idCategoriaSeleccionada = 0;

            txtNombre.Clear();
            txtDescripcion.Clear();

            dgvCategorias.ClearSelection();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}

