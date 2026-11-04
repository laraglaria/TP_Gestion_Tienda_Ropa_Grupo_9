namespace TiendaRopaApp
{
    partial class FormClientes
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
            dgvClientes = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblEmail = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            lblNombre = new Label();
            lblTitulo = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 16F);
            lblTituloPrincipal.Location = new Point(12, 31);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(264, 45);
            lblTituloPrincipal.TabIndex = 32;
            lblTituloPrincipal.Text = "TIENDA DE ROPA";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 505);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(804, 95);
            dgvClientes.TabIndex = 31;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(14, 456);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(250, 456);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(368, 456);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Location = new Point(132, 456);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 27;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(400, 282);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(416, 31);
            txtTelefono.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 282);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(382, 31);
            txtEmail.TabIndex = 25;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(400, 197);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(416, 31);
            txtApellido.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 197);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(382, 31);
            txtNombre.TabIndex = 23;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(12, 241);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(97, 38);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(400, 156);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(135, 38);
            lblApellido.TabIndex = 21;
            lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(400, 241);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(138, 38);
            lblTelefono.TabIndex = 20;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(14, 156);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(125, 38);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(12, 76);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(291, 45);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Gestión de clientes";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 367);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(804, 31);
            txtDireccion.TabIndex = 34;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(12, 326);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(148, 38);
            lblDireccion.TabIndex = 33;
            lblDireccion.Text = "Dirección:";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 637);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(lblTituloPrincipal);
            Controls.Add(dgvClientes);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPrincipal;
        private DataGridView dgvClientes;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnModificar;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblNombre;
        private Label lblTitulo;
        private TextBox txtDireccion;
        private Label lblDireccion;
    }
}