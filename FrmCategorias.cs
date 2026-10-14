using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TiendaRopa.Models;
using TiendaRopa.Repositories;


namespace TiendaRopa.WinForms;

public partial class FrmCategorias : Form
{
    private GenericRepository<Categoria> _repo = new GenericRepository<Categoria>();
    private int _idSeleccionado = 0;

    public FrmCategorias()
    {
        InitializeComponent();
        CargarGrilla();
    }

    private void FrmCategorias_Load(object sender, EventArgs e)
    {
    }

    private void CargarGrilla()
    {
        dgvCategorias.DataSource = null;
        dgvCategorias.DataSource = _repo.ObtenerTodos();
    }

    private void Limpiar()
    {
        txtNombre.Clear();
        txtDescripcion.Clear();
        _idSeleccionado = 0;
        CargarGrilla();
    }

    // ALTA
    private void btnAgregar_Click(object sender, EventArgs e)
    {
        if (txtNombre.Text == "")
        {
            MessageBox.Show("Ingresá el nombre de la categoría.");
            return;
        }

        Categoria categoria = new Categoria();
        categoria.Nombre = txtNombre.Text;
        categoria.Descripcion = txtDescripcion.Text;

        _repo.Agregar(categoria);
        Limpiar();
    }

    // Al hacer clic en una fila, se cargan los datos en los cuadros de texto
    private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        Categoria categoria = (Categoria)dgvCategorias.Rows[e.RowIndex].DataBoundItem;
        _idSeleccionado = categoria.Id;
        txtNombre.Text = categoria.Nombre;
        txtDescripcion.Text = categoria.Descripcion;
    }

    // MODIFICACIÓN
    private void btnModificar_Click(object sender, EventArgs e)
    {
        if (_idSeleccionado == 0)
        {
            MessageBox.Show("Seleccioná una categoría de la lista.");
            return;
        }

        Categoria categoria = _repo.ObtenerPorId(_idSeleccionado);
        categoria.Nombre = txtNombre.Text;
        categoria.Descripcion = txtDescripcion.Text;

        _repo.Modificar(categoria);
        Limpiar();
    }

    // BAJA
    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (_idSeleccionado == 0)
        {
            MessageBox.Show("Seleccioná una categoría de la lista.");
            return;
        }

        _repo.Eliminar(_idSeleccionado);
        Limpiar();
    }
}
