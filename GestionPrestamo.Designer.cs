namespace BibliotecaLosInge
{
    partial class GestionPrestamo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.ComboBox cboNombreMiembro;
        private System.Windows.Forms.ComboBox cboTituloLibro;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.ComboBox cboTipoLibro;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Button btnModificarPrestamo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.cboNombreMiembro = new System.Windows.Forms.ComboBox();
            this.cboTituloLibro = new System.Windows.Forms.ComboBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.cboTipoLibro = new System.Windows.Forms.ComboBox();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.btnModificarPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.ItemHeight = 16;
            this.lstPrestamos.Location = new System.Drawing.Point(12, 12);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(400, 180);
            this.lstPrestamos.TabIndex = 0;
            // 
            // cboNombreMiembro
            // 
            this.cboNombreMiembro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreMiembro.FormattingEnabled = true;
            this.cboNombreMiembro.Location = new System.Drawing.Point(12, 210);
            this.cboNombreMiembro.Name = "cboNombreMiembro";
            this.cboNombreMiembro.Size = new System.Drawing.Size(200, 24);
            this.cboNombreMiembro.TabIndex = 1;
            // 
            // cboTituloLibro
            // 
            this.cboTituloLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTituloLibro.FormattingEnabled = true;
            this.cboTituloLibro.Location = new System.Drawing.Point(12, 240);
            this.cboTituloLibro.Name = "cboTituloLibro";
            this.cboTituloLibro.Size = new System.Drawing.Size(200, 24);
            this.cboTituloLibro.TabIndex = 2;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(12, 270);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaSalida.TabIndex = 3;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(12, 300);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDevolucion.TabIndex = 4;
            // 
            // cboTipoLibro
            // 
            this.cboTipoLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoLibro.FormattingEnabled = true;
            this.cboTipoLibro.Location = new System.Drawing.Point(12, 330);
            this.cboTipoLibro.Name = "cboTipoLibro";
            this.cboTipoLibro.Size = new System.Drawing.Size(200, 24);
            this.cboTipoLibro.TabIndex = 5;
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(220, 210);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(75, 30);
            this.btnAgregarPrestamo.TabIndex = 6;
            this.btnAgregarPrestamo.Text = "Agregar";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = true;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(220, 250);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(75, 30);
            this.btnEliminarPrestamo.TabIndex = 7;
            this.btnEliminarPrestamo.Text = "Eliminar";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.Location = new System.Drawing.Point(220, 290);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Size = new System.Drawing.Size(75, 30);
            this.btnModificarPrestamo.TabIndex = 8;
            this.btnModificarPrestamo.Text = "Modificar";
            this.btnModificarPrestamo.UseVisualStyleBackColor = true;
            this.btnModificarPrestamo.Click += new System.EventHandler(this.btnModificarPrestamo_Click);
            // 
            // GestionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 361);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.btnAgregarPrestamo);
            this.Controls.Add(this.cboTipoLibro);
            this.Controls.Add(this.dtpFechaDevolucion);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.cboTituloLibro);
            this.Controls.Add(this.cboNombreMiembro);
            this.Controls.Add(this.lstPrestamos);
            this.Name = "GestionPrestamo";
            this.Text = "Gestión de Préstamos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
