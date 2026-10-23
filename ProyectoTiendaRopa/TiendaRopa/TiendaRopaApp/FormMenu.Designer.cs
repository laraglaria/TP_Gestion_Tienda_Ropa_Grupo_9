namespace TiendaRopaApp
{
    partial class FormMenu
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
            lblTitulo = new Label();
            lblTituloPrincipal = new Label();
            btnProductos = new Button();
            btnCategorias = new Button();
            btnClientes = new Button();
            btnVendedores = new Button();
            btnVentas = new Button();
            btnReportes = new Button();
            lblSeleccion = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(12, 75);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 45);
            lblTitulo.TabIndex = 49;
            lblTitulo.Text = "Menú principal";
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 16F);
            lblTituloPrincipal.Location = new Point(12, 30);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(264, 45);
            lblTituloPrincipal.TabIndex = 48;
            lblTituloPrincipal.Text = "TIENDA DE ROPA";
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Location = new Point(12, 218);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(187, 34);
            btnProductos.TabIndex = 50;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.Location = new Point(12, 258);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(187, 34);
            btnCategorias.TabIndex = 51;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Location = new Point(12, 298);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(187, 34);
            btnClientes.TabIndex = 52;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVendedores
            // 
            btnVendedores.Cursor = Cursors.Hand;
            btnVendedores.Location = new Point(12, 338);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Size = new Size(187, 34);
            btnVendedores.TabIndex = 53;
            btnVendedores.Text = "Vendedores";
            btnVendedores.UseVisualStyleBackColor = true;
            btnVendedores.Click += btnVendedores_Click;
            // 
            // btnVentas
            // 
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Location = new Point(12, 378);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(187, 34);
            btnVentas.TabIndex = 54;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Location = new Point(12, 418);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(187, 34);
            btnReportes.TabIndex = 55;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccion.Location = new Point(12, 157);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(316, 38);
            lblSeleccion.TabIndex = 56;
            lblSeleccion.Text = "Seleccione una opción:";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 492);
            Controls.Add(lblSeleccion);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Controls.Add(btnVendedores);
            Controls.Add(btnClientes);
            Controls.Add(btnCategorias);
            Controls.Add(btnProductos);
            Controls.Add(lblTitulo);
            Controls.Add(lblTituloPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTituloPrincipal;
        private Button btnProductos;
        private Button btnCategorias;
        private Button btnClientes;
        private Button btnVendedores;
        private Button btnVentas;
        private Button btnReportes;
        private Label lblSeleccion;
    }
}