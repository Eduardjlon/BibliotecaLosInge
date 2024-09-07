namespace BibliotecaLosInge
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que está utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            btnGestionLibro = new Button();
            btnGestionMiembro = new Button();
            btnGestionPrestamo = new Button();
            Creditos = new Label();
            Propietarios = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGestionLibro
            // 
            btnGestionLibro.BackColor = Color.Lime;
            btnGestionLibro.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestionLibro.Location = new Point(48, 44);
            btnGestionLibro.Name = "btnGestionLibro";
            btnGestionLibro.Size = new Size(150, 61);
            btnGestionLibro.TabIndex = 0;
            btnGestionLibro.Text = "Gestionar Libros";
            btnGestionLibro.UseVisualStyleBackColor = false;
            btnGestionLibro.Click += btnGestionLibro_Click;
            // 
            // btnGestionMiembro
            // 
            btnGestionMiembro.BackColor = Color.Cyan;
            btnGestionMiembro.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestionMiembro.Location = new Point(204, 110);
            btnGestionMiembro.Name = "btnGestionMiembro";
            btnGestionMiembro.Size = new Size(150, 61);
            btnGestionMiembro.TabIndex = 1;
            btnGestionMiembro.Text = "Gestionar Miembros";
            btnGestionMiembro.UseVisualStyleBackColor = false;
            btnGestionMiembro.Click += btnGestionMiembro_Click;
            // 
            // btnGestionPrestamo
            // 
            btnGestionPrestamo.BackColor = Color.Teal;
            btnGestionPrestamo.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestionPrestamo.Location = new Point(360, 44);
            btnGestionPrestamo.Name = "btnGestionPrestamo";
            btnGestionPrestamo.Size = new Size(150, 61);
            btnGestionPrestamo.TabIndex = 2;
            btnGestionPrestamo.Text = "Gestionar Préstamos";
            btnGestionPrestamo.UseVisualStyleBackColor = false;
            btnGestionPrestamo.Click += btnGestionPrestamo_Click;
            // 
            // Creditos
            // 
            Creditos.AutoSize = true;
            Creditos.BackColor = SystemColors.ControlText;
            Creditos.BorderStyle = BorderStyle.Fixed3D;
            Creditos.Cursor = Cursors.Cross;
            Creditos.FlatStyle = FlatStyle.Flat;
            Creditos.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Creditos.ForeColor = SystemColors.ControlLightLight;
            Creditos.Location = new Point(80, 9);
            Creditos.Name = "Creditos";
            Creditos.Size = new Size(409, 22);
            Creditos.TabIndex = 3;
            Creditos.Text = "Bienvenido a la biblioteca \"Los Inges Estrella\"\r\n";
            // 
            // Propietarios
            // 
            Propietarios.AutoSize = true;
            Propietarios.BackColor = SystemColors.ControlText;
            Propietarios.BorderStyle = BorderStyle.Fixed3D;
            Propietarios.CausesValidation = false;
            Propietarios.Cursor = Cursors.Cross;
            Propietarios.FlatStyle = FlatStyle.Flat;
            Propietarios.Font = new Font("Microsoft Yi Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Propietarios.ForeColor = SystemColors.ControlLightLight;
            Propietarios.Location = new Point(516, 185);
            Propietarios.Name = "Propietarios";
            Propietarios.Size = new Size(89, 67);
            Propietarios.TabIndex = 4;
            Propietarios.Text = "Propietarios:\r\nAndrea Lopez\r\nJuan Pirir\r\nDaniela Lopez\r\nJonathan Jolón";
            Propietarios.TextAlign = ContentAlignment.BottomCenter;
            Propietarios.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_09_07_at_1_04_50_AM__2_;
            pictureBox1.Location = new Point(378, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 95);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(617, 261);
            Controls.Add(pictureBox1);
            Controls.Add(Propietarios);
            Controls.Add(Creditos);
            Controls.Add(btnGestionPrestamo);
            Controls.Add(btnGestionMiembro);
            Controls.Add(btnGestionLibro);
            Name = "MainForm";
            Text = "Biblioteca Los Inge";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGestionLibro;
        private System.Windows.Forms.Button btnGestionMiembro;
        private System.Windows.Forms.Button btnGestionPrestamo;
        private Label Creditos;
        private Label Propietarios;
        private PictureBox pictureBox1;
    }
}
