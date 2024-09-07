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
            label1 = new Label();
            SuspendLayout();
            // 
            // lstPrestamos
            // 
            lstPrestamos.BackColor = Color.Blue;
            lstPrestamos.ForeColor = Color.WhiteSmoke;
            lstPrestamos.FormattingEnabled = true;
            lstPrestamos.Location = new Point(11, 15);
            lstPrestamos.Margin = new Padding(3, 4, 3, 4);
            lstPrestamos.Name = "lstPrestamos";
            lstPrestamos.Size = new Size(1045, 224);
            lstPrestamos.TabIndex = 0;
            // 
            // cboNombreMiembro
            // 
            cboNombreMiembro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNombreMiembro.FormattingEnabled = true;
            cboNombreMiembro.Location = new Point(102, 248);
            cboNombreMiembro.Margin = new Padding(3, 4, 3, 4);
            cboNombreMiembro.Name = "cboNombreMiembro";
            cboNombreMiembro.Size = new Size(219, 28);
            cboNombreMiembro.TabIndex = 1;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Location = new Point(707, 246);
            dtpFechaSalida.Margin = new Padding(3, 4, 3, 4);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(286, 27);
            dtpFechaSalida.TabIndex = 3;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(707, 281);
            dtpFechaDevolucion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(286, 27);
            dtpFechaDevolucion.TabIndex = 4;
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.BackColor = Color.Lime;
            btnAgregarPrestamo.ForeColor = Color.Black;
            btnAgregarPrestamo.Location = new Point(981, 331);
            btnAgregarPrestamo.Margin = new Padding(3, 4, 3, 4);
            btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            btnAgregarPrestamo.Size = new Size(75, 37);
            btnAgregarPrestamo.TabIndex = 6;
            btnAgregarPrestamo.Text = "Agregar";
            btnAgregarPrestamo.UseVisualStyleBackColor = false;
            btnAgregarPrestamo.Click += btnAgregarPrestamo_Click;
            // 
            // btnEliminarPrestamo
            // 
            btnEliminarPrestamo.BackColor = Color.Red;
            btnEliminarPrestamo.ForeColor = Color.White;
            btnEliminarPrestamo.Location = new Point(981, 421);
            btnEliminarPrestamo.Margin = new Padding(3, 4, 3, 4);
            btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            btnEliminarPrestamo.Size = new Size(75, 37);
            btnEliminarPrestamo.TabIndex = 7;
            btnEliminarPrestamo.Text = "Eliminar";
            btnEliminarPrestamo.UseVisualStyleBackColor = false;
            btnEliminarPrestamo.Click += btnEliminarPrestamo_Click;
            // 
            // btnModificarPrestamo
            // 
            btnModificarPrestamo.BackColor = Color.FromArgb(0, 0, 192);
            btnModificarPrestamo.ForeColor = SystemColors.ButtonFace;
            btnModificarPrestamo.Location = new Point(981, 376);
            btnModificarPrestamo.Margin = new Padding(3, 4, 3, 4);
            btnModificarPrestamo.Name = "btnModificarPrestamo";
            btnModificarPrestamo.Size = new Size(75, 37);
            btnModificarPrestamo.TabIndex = 8;
            btnModificarPrestamo.Text = "Modificar";
            btnModificarPrestamo.UseVisualStyleBackColor = false;
            btnModificarPrestamo.Click += btnModificarPrestamo_Click;
            // 
            // Miembro
            // 
            Miembro.AutoSize = true;
            Miembro.Location = new Point(11, 259);
            Miembro.Name = "Miembro";
            Miembro.Size = new Size(70, 20);
            Miembro.TabIndex = 9;
            Miembro.Text = "Miembro";
            Miembro.Click += Miembro_Click;
            // 
            // FechaRetiro
            // 
            FechaRetiro.AutoSize = true;
            FechaRetiro.Location = new Point(541, 259);
            FechaRetiro.Name = "FechaRetiro";
            FechaRetiro.Size = new Size(170, 20);
            FechaRetiro.TabIndex = 11;
            FechaRetiro.Text = "Fecha Retirada del Libro";
            FechaRetiro.Click += label1_Click;
            // 
            // FechaEntrega
            // 
            FechaEntrega.AutoSize = true;
            FechaEntrega.Location = new Point(546, 297);
            FechaEntrega.Name = "FechaEntrega";
            FechaEntrega.Size = new Size(165, 20);
            FechaEntrega.TabIndex = 12;
            FechaEntrega.Text = "Fecha Entrega del Libro";
            FechaEntrega.Click += FechaEntrega_Click;
            // 
            // ListFisico
            // 
            ListFisico.BackColor = Color.FromArgb(255, 128, 0);
            ListFisico.ForeColor = Color.Black;
            ListFisico.FormattingEnabled = true;
            ListFisico.Location = new Point(17, 351);
            ListFisico.Margin = new Padding(3, 4, 3, 4);
            ListFisico.Name = "ListFisico";
            ListFisico.Size = new Size(312, 124);
            ListFisico.TabIndex = 13;
            // 
            // ListElectronico
            // 
            ListElectronico.BackColor = Color.Yellow;
            ListElectronico.ForeColor = Color.Black;
            ListElectronico.FormattingEnabled = true;
            ListElectronico.Location = new Point(382, 351);
            ListElectronico.Margin = new Padding(3, 4, 3, 4);
            ListElectronico.Name = "ListElectronico";
            ListElectronico.Size = new Size(576, 124);
            ListElectronico.TabIndex = 14;
            // 
            // cboTipoLibro
            // 
            cboTipoLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoLibro.FormattingEnabled = true;
            cboTipoLibro.Location = new Point(102, 287);
            cboTipoLibro.Margin = new Padding(3, 4, 3, 4);
            cboTipoLibro.Name = "cboTipoLibro";
            cboTipoLibro.Size = new Size(219, 28);
            cboTipoLibro.TabIndex = 15;
            cboTipoLibro.SelectedIndexChanged += cboTipoLibro_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 297);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 16;
            label1.Text = "Tipo Libro";
            // 
            // GestionPrestamo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1184, 492);
            Controls.Add(label1);
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
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
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

        private Label label1;
    }
}
