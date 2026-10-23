namespace TiendaRopaApp
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloPrincipal = new Label();
            lblTitulo = new Label();
            cmbProductos = new ComboBox();
            cmbClientes = new ComboBox();
            cmbVendedores = new ComboBox();
            lblSeleccionarCliente = new Label();
            lblSeleccionarVendedor = new Label();
            lblSeleccionarProductos = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnQuitarDetalle = new Button();
            btnAgregarDetalle = new Button();
            dgvDetalles = new DataGridView();
            lblTotal = new Label();
            btnRegistrarVenta = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 16F);
            lblTituloPrincipal.Location = new Point(12, 9);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(264, 45);
            lblTituloPrincipal.TabIndex = 46;
            lblTituloPrincipal.Text = "TIENDA DE ROPA";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(12, 65);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(274, 45);
            lblTitulo.TabIndex = 47;
            lblTitulo.Text = "Gestión de ventas";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(12, 284);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(316, 33);
            cmbProductos.TabIndex = 48;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(12, 177);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(316, 33);
            cmbClientes.TabIndex = 49;
            // 
            // cmbVendedores
            // 
            cmbVendedores.FormattingEnabled = true;
            cmbVendedores.Location = new Point(334, 177);
            cmbVendedores.Name = "cmbVendedores";
            cmbVendedores.Size = new Size(336, 33);
            cmbVendedores.TabIndex = 50;
            // 
            // lblSeleccionarCliente
            // 
            lblSeleccionarCliente.AutoSize = true;
            lblSeleccionarCliente.Location = new Point(12, 140);
            lblSeleccionarCliente.Name = "lblSeleccionarCliente";
            lblSeleccionarCliente.Size = new Size(159, 25);
            lblSeleccionarCliente.TabIndex = 51;
            lblSeleccionarCliente.Text = "Seleccionar cliente:";
            // 
            // lblSeleccionarVendedor
            // 
            lblSeleccionarVendedor.AutoSize = true;
            lblSeleccionarVendedor.Location = new Point(334, 140);
            lblSeleccionarVendedor.Name = "lblSeleccionarVendedor";
            lblSeleccionarVendedor.Size = new Size(185, 25);
            lblSeleccionarVendedor.TabIndex = 52;
            lblSeleccionarVendedor.Text = "Seleccionar vendedor:";
            // 
            // lblSeleccionarProductos
            // 
            lblSeleccionarProductos.AutoSize = true;
            lblSeleccionarProductos.Location = new Point(12, 256);
            lblSeleccionarProductos.Name = "lblSeleccionarProductos";
            lblSeleccionarProductos.Size = new Size(183, 25);
            lblSeleccionarProductos.TabIndex = 53;
            lblSeleccionarProductos.Text = "Seleccionar producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(334, 256);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(165, 25);
            lblCantidad.TabIndex = 54;
            lblCantidad.Text = "Ingrese la cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(334, 286);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(336, 31);
            txtCantidad.TabIndex = 55;
            // 
            // btnQuitarDetalle
            // 
            btnQuitarDetalle.Location = new Point(558, 342);
            btnQuitarDetalle.Name = "btnQuitarDetalle";
            btnQuitarDetalle.Size = new Size(112, 34);
            btnQuitarDetalle.TabIndex = 56;
            btnQuitarDetalle.Text = "Quitar";
            btnQuitarDetalle.UseVisualStyleBackColor = true;
            btnQuitarDetalle.Click += btnQuitarDetalle_Click;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.Location = new Point(440, 342);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(112, 34);
            btnAgregarDetalle.TabIndex = 57;
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarDetalle.UseVisualStyleBackColor = true;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(12, 398);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidth = 62;
            dgvDetalles.Size = new Size(658, 127);
            dgvDetalles.TabIndex = 58;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16F);
            lblTotal.Location = new Point(12, 548);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(95, 45);
            lblTotal.TabIndex = 59;
            lblTotal.Text = "Total:";
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(440, 559);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(112, 34);
            btnRegistrarVenta.TabIndex = 60;
            btnRegistrarVenta.Text = "Registrar";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(558, 559);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 61;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 617);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(lblTotal);
            Controls.Add(dgvDetalles);
            Controls.Add(btnAgregarDetalle);
            Controls.Add(btnQuitarDetalle);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblSeleccionarProductos);
            Controls.Add(lblSeleccionarVendedor);
            Controls.Add(lblSeleccionarCliente);
            Controls.Add(cmbVendedores);
            Controls.Add(cmbClientes);
            Controls.Add(cmbProductos);
            Controls.Add(lblTitulo);
            Controls.Add(lblTituloPrincipal);
            Name = "FormVentas";
            Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPrincipal;
        private Label lblTitulo;
        private ComboBox cmbProductos;
        private ComboBox cmbClientes;
        private ComboBox cmbVendedores;
        private Label lblSeleccionarCliente;
        private Label lblSeleccionarVendedor;
        private Label lblSeleccionarProductos;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnQuitarDetalle;
        private Button btnAgregarDetalle;
        private DataGridView dgvDetalles;
        private Label lblTotal;
        private Button btnRegistrarVenta;
        private Button btnLimpiar;
    }
}