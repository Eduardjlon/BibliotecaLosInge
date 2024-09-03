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
            SuspendLayout();
            // 
            // btnGestionLibro
            // 
            btnGestionLibro.BackColor = Color.Lime;
            btnGestionLibro.Location = new Point(50, 50);
            btnGestionLibro.Name = "btnGestionLibro";
            btnGestionLibro.Size = new Size(150, 30);
            btnGestionLibro.TabIndex = 0;
            btnGestionLibro.Text = "Gestionar Libros";
            btnGestionLibro.UseVisualStyleBackColor = false;
            btnGestionLibro.Click += btnGestionLibro_Click;
            // 
            // btnGestionMiembro
            // 
            btnGestionMiembro.BackColor = Color.Cyan;
            btnGestionMiembro.Location = new Point(50, 100);
            btnGestionMiembro.Name = "btnGestionMiembro";
            btnGestionMiembro.Size = new Size(150, 30);
            btnGestionMiembro.TabIndex = 1;
            btnGestionMiembro.Text = "Gestionar Miembros";
            btnGestionMiembro.UseVisualStyleBackColor = false;
            btnGestionMiembro.Click += btnGestionMiembro_Click;
            // 
            // btnGestionPrestamo
            // 
            btnGestionPrestamo.Location = new Point(50, 150);
            btnGestionPrestamo.Name = "btnGestionPrestamo";
            btnGestionPrestamo.Size = new Size(150, 30);
            btnGestionPrestamo.TabIndex = 2;
            btnGestionPrestamo.Text = "Gestionar Préstamos";
            btnGestionPrestamo.UseVisualStyleBackColor = true;
            btnGestionPrestamo.Click += btnGestionPrestamo_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(btnGestionPrestamo);
            Controls.Add(btnGestionMiembro);
            Controls.Add(btnGestionLibro);
            Name = "MainForm";
            Text = "Biblioteca Los Inge";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnGestionLibro;
        private System.Windows.Forms.Button btnGestionMiembro;
        private System.Windows.Forms.Button btnGestionPrestamo;
    }
}
