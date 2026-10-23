namespace TiendaRopaApp
{
    partial class FormReportes
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
            lblSubTitulo = new Label();
            lblTituloPrincipal = new Label();
            lblTitulo = new Label();
            cmbTipoReporte = new ComboBox();
            dgvReportes = new DataGridView();
            btnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.AutoSize = true;
            lblSubTitulo.Font = new Font("Segoe UI", 16F);
            lblSubTitulo.Location = new Point(12, 65);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(146, 45);
            lblSubTitulo.TabIndex = 49;
            lblSubTitulo.Text = "Reportes";
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 16F);
            lblTituloPrincipal.Location = new Point(12, 20);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(264, 45);
            lblTituloPrincipal.TabIndex = 48;
            lblTituloPrincipal.Text = "TIENDA DE ROPA";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 139);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(279, 38);
            lblTitulo.TabIndex = 53;
            lblTitulo.Text = "Seleccionar reporte:";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(12, 189);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(316, 33);
            cmbTipoReporte.TabIndex = 52;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(12, 261);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersWidth = 62;
            dgvReportes.Size = new Size(658, 127);
            dgvReportes.TabIndex = 59;
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Location = new Point(348, 187);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 34);
            btnConsultar.TabIndex = 60;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 430);
            Controls.Add(btnConsultar);
            Controls.Add(dgvReportes);
            Controls.Add(lblTitulo);
            Controls.Add(cmbTipoReporte);
            Controls.Add(lblSubTitulo);
            Controls.Add(lblTituloPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubTitulo;
        private Label lblTituloPrincipal;
        private Label lblTitulo;
        private ComboBox cmbTipoReporte;
        private DataGridView dgvReportes;
        private Button btnConsultar;
    }
}