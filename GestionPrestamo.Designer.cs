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
            lstPrestamos = new ListBox();
            cboNombreMiembro = new ComboBox();
            cboTituloLibro = new ComboBox();
            dtpFechaSalida = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            cboTipoLibro = new ComboBox();
            btnAgregarPrestamo = new Button();
            btnEliminarPrestamo = new Button();
            btnModificarPrestamo = new Button();
            Miembro = new Label();
            Librp = new Label();
            FechaRetiro = new Label();
            FechaEntrega = new Label();
            SuspendLayout();
            // 
            // lstPrestamos
            // 
            lstPrestamos.BackColor = Color.Blue;
            lstPrestamos.ForeColor = Color.WhiteSmoke;
            lstPrestamos.FormattingEnabled = true;
            lstPrestamos.ItemHeight = 15;
            lstPrestamos.Location = new Point(10, 11);
            lstPrestamos.Name = "lstPrestamos";
            lstPrestamos.Size = new Size(699, 169);
            lstPrestamos.TabIndex = 0;
            // 
            // cboNombreMiembro
            // 
            cboNombreMiembro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNombreMiembro.FormattingEnabled = true;
            cboNombreMiembro.Location = new Point(269, 201);
            cboNombreMiembro.Name = "cboNombreMiembro";
            cboNombreMiembro.Size = new Size(192, 23);
            cboNombreMiembro.TabIndex = 1;
            // 
            // cboTituloLibro
            // 
            cboTituloLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTituloLibro.FormattingEnabled = true;
            cboTituloLibro.Location = new Point(269, 230);
            cboTituloLibro.Name = "cboTituloLibro";
            cboTituloLibro.Size = new Size(192, 23);
            cboTituloLibro.TabIndex = 2;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Location = new Point(12, 262);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(251, 23);
            dtpFechaSalida.TabIndex = 3;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(467, 262);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(242, 23);
            dtpFechaDevolucion.TabIndex = 4;
            // 
            // cboTipoLibro
            // 
            cboTipoLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoLibro.FormattingEnabled = true;
            cboTipoLibro.Location = new Point(269, 262);
            cboTipoLibro.Name = "cboTipoLibro";
            cboTipoLibro.Size = new Size(192, 23);
            cboTipoLibro.TabIndex = 5;
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.BackColor = Color.Lime;
            btnAgregarPrestamo.Location = new Point(332, 291);
            btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            btnAgregarPrestamo.Size = new Size(66, 28);
            btnAgregarPrestamo.TabIndex = 6;
            btnAgregarPrestamo.Text = "Agregar";
            btnAgregarPrestamo.UseVisualStyleBackColor = false;
            btnAgregarPrestamo.Click += btnAgregarPrestamo_Click;
            // 
            // btnEliminarPrestamo
            // 
            btnEliminarPrestamo.BackColor = Color.Red;
            btnEliminarPrestamo.ForeColor = Color.White;
            btnEliminarPrestamo.Location = new Point(260, 291);
            btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            btnEliminarPrestamo.Size = new Size(66, 28);
            btnEliminarPrestamo.TabIndex = 7;
            btnEliminarPrestamo.Text = "Eliminar";
            btnEliminarPrestamo.UseVisualStyleBackColor = false;
            btnEliminarPrestamo.Click += btnEliminarPrestamo_Click;
            // 
            // btnModificarPrestamo
            // 
            btnModificarPrestamo.BackColor = Color.FromArgb(0, 0, 192);
            btnModificarPrestamo.ForeColor = SystemColors.ButtonFace;
            btnModificarPrestamo.Location = new Point(404, 291);
            btnModificarPrestamo.Name = "btnModificarPrestamo";
            btnModificarPrestamo.Size = new Size(66, 28);
            btnModificarPrestamo.TabIndex = 8;
            btnModificarPrestamo.Text = "Modificar";
            btnModificarPrestamo.UseVisualStyleBackColor = false;
            btnModificarPrestamo.Click += btnModificarPrestamo_Click;
            // 
            // Miembro
            // 
            Miembro.AutoSize = true;
            Miembro.Location = new Point(192, 204);
            Miembro.Name = "Miembro";
            Miembro.Size = new Size(56, 15);
            Miembro.TabIndex = 9;
            Miembro.Text = "Miembro";
            // 
            // Librp
            // 
            Librp.AutoSize = true;
            Librp.Location = new Point(203, 233);
            Librp.Name = "Librp";
            Librp.Size = new Size(34, 15);
            Librp.TabIndex = 10;
            Librp.Text = "Libro";
            // 
            // FechaRetiro
            // 
            FechaRetiro.AutoSize = true;
            FechaRetiro.Location = new Point(62, 288);
            FechaRetiro.Name = "FechaRetiro";
            FechaRetiro.Size = new Size(133, 15);
            FechaRetiro.TabIndex = 11;
            FechaRetiro.Text = "Fecha Retirada del Libro";
            FechaRetiro.Click += label1_Click;
            // 
            // FechaEntrega
            // 
            FechaEntrega.AutoSize = true;
            FechaEntrega.Location = new Point(532, 291);
            FechaEntrega.Name = "FechaEntrega";
            FechaEntrega.Size = new Size(130, 15);
            FechaEntrega.TabIndex = 12;
            FechaEntrega.Text = "Fecha Entrega del Libro";
            FechaEntrega.Click += FechaEntrega_Click;
            // 
            // GestionPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 338);
            Controls.Add(FechaEntrega);
            Controls.Add(FechaRetiro);
            Controls.Add(Librp);
            Controls.Add(Miembro);
            Controls.Add(btnModificarPrestamo);
            Controls.Add(btnEliminarPrestamo);
            Controls.Add(btnAgregarPrestamo);
            Controls.Add(cboTipoLibro);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaSalida);
            Controls.Add(cboTituloLibro);
            Controls.Add(cboNombreMiembro);
            Controls.Add(lstPrestamos);
            Name = "GestionPrestamo";
            Text = "Gestión de Préstamos";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label Miembro;
        private Label Librp;
        private Label FechaRetiro;
        private Label FechaEntrega;
    }
}
