namespace BibliotecaLosInge
{
    partial class GestionPrestamo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.ComboBox cboNombreMiembro;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Button btnModificarPrestamo;
        private System.Windows.Forms.Label Miembro;
        private System.Windows.Forms.Label FechaRetiro;
        private System.Windows.Forms.Label FechaEntrega;
        private System.Windows.Forms.ListBox ListFisico;
        private System.Windows.Forms.ListBox ListElectronico;
        private System.Windows.Forms.ComboBox cboTipoLibro;

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
            dtpFechaSalida = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            btnAgregarPrestamo = new Button();
            btnEliminarPrestamo = new Button();
            btnModificarPrestamo = new Button();
            Miembro = new Label();
            FechaRetiro = new Label();
            FechaEntrega = new Label();
            ListFisico = new ListBox();
            ListElectronico = new ListBox();
            cboTipoLibro = new ComboBox();
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
            cboNombreMiembro.Location = new Point(74, 186);
            cboNombreMiembro.Name = "cboNombreMiembro";
            cboNombreMiembro.Size = new Size(192, 23);
            cboNombreMiembro.TabIndex = 1;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Location = new Point(458, 186);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(251, 23);
            dtpFechaSalida.TabIndex = 3;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(458, 215);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(251, 23);
            dtpFechaDevolucion.TabIndex = 4;
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.BackColor = Color.Lime;
            btnAgregarPrestamo.Location = new Point(643, 244);
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
            btnEliminarPrestamo.Location = new Point(643, 312);
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
            btnModificarPrestamo.Location = new Point(643, 278);
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
            Miembro.Location = new Point(10, 194);
            Miembro.Name = "Miembro";
            Miembro.Size = new Size(56, 15);
            Miembro.TabIndex = 9;
            Miembro.Text = "Miembro";
            Miembro.Click += Miembro_Click;
            // 
            // FechaRetiro
            // 
            FechaRetiro.AutoSize = true;
            FechaRetiro.Location = new Point(319, 194);
            FechaRetiro.Name = "FechaRetiro";
            FechaRetiro.Size = new Size(133, 15);
            FechaRetiro.TabIndex = 11;
            FechaRetiro.Text = "Fecha Retirada del Libro";
            FechaRetiro.Click += label1_Click;
            // 
            // FechaEntrega
            // 
            FechaEntrega.AutoSize = true;
            FechaEntrega.Location = new Point(319, 223);
            FechaEntrega.Name = "FechaEntrega";
            FechaEntrega.Size = new Size(130, 15);
            FechaEntrega.TabIndex = 12;
            FechaEntrega.Text = "Fecha Entrega del Libro";
            FechaEntrega.Click += FechaEntrega_Click;
            // 
            // ListFisico
            // 
            ListFisico.BackColor = Color.FromArgb(255, 128, 0);
            ListFisico.ForeColor = Color.Black;
            ListFisico.FormattingEnabled = true;
            ListFisico.ItemHeight = 15;
            ListFisico.Location = new Point(10, 263);
            ListFisico.Name = "ListFisico";
            ListFisico.Size = new Size(240, 94);
            ListFisico.TabIndex = 13;
            // 
            // ListElectronico
            // 
            ListElectronico.BackColor = Color.Yellow;
            ListElectronico.ForeColor = Color.Black;
            ListElectronico.FormattingEnabled = true;
            ListElectronico.ItemHeight = 15;
            ListElectronico.Location = new Point(256, 263);
            ListElectronico.Name = "ListElectronico";
            ListElectronico.Size = new Size(240, 94);
            ListElectronico.TabIndex = 14;
            // 
            // cboTipoLibro
            // 
            cboTipoLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoLibro.FormattingEnabled = true;
            cboTipoLibro.Location = new Point(74, 234);
            cboTipoLibro.Name = "cboTipoLibro";
            cboTipoLibro.Size = new Size(192, 23);
            cboTipoLibro.TabIndex = 15;
            cboTipoLibro.SelectedIndexChanged += cboTipoLibro_SelectedIndexChanged;
            // 
            // GestionPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 369);
            Controls.Add(cboTipoLibro);
            Controls.Add(ListElectronico);
            Controls.Add(ListFisico);
            Controls.Add(FechaEntrega);
            Controls.Add(FechaRetiro);
            Controls.Add(Miembro);
            Controls.Add(btnModificarPrestamo);
            Controls.Add(btnEliminarPrestamo);
            Controls.Add(btnAgregarPrestamo);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaSalida);
            Controls.Add(cboNombreMiembro);
            Controls.Add(lstPrestamos);
            Name = "GestionPrestamo";
            Text = "Gestión de Préstamos";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Miembro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FechaEntrega_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
