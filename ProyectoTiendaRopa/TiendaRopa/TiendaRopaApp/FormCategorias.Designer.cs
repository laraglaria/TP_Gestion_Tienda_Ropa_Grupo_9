namespace TiendaRopaApp
{
    partial class FormCategorias
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvCategorias = new DataGridView();
            lblTituloPrincipal = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(29, 158);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(133, 38);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 200);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(348, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(383, 200);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(379, 31);
            txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(383, 158);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(177, 38);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción:";
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(265, 263);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(383, 263);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Location = new Point(147, 263);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(29, 263);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(29, 314);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 62;
            dgvCategorias.Size = new Size(733, 111);
            dgvCategorias.TabIndex = 8;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 16F);
            lblTituloPrincipal.Location = new Point(29, 9);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(264, 45);
            lblTituloPrincipal.TabIndex = 18;
            lblTituloPrincipal.Text = "TIENDA DE ROPA";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(29, 63);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(329, 45);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Gestión de categorías";
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblTituloPrincipal);
            Controls.Add(dgvCategorias);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvCategorias;
        private Label lblTituloPrincipal;
        private Label lblTitulo;
    }
}