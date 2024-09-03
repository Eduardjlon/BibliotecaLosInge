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
            this.btnGestionLibro = new System.Windows.Forms.Button();
            this.btnGestionMiembro = new System.Windows.Forms.Button();
            this.btnGestionPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionLibro
            // 
            this.btnGestionLibro.Location = new System.Drawing.Point(50, 50);
            this.btnGestionLibro.Name = "btnGestionLibro";
            this.btnGestionLibro.Size = new System.Drawing.Size(150, 30);
            this.btnGestionLibro.TabIndex = 0;
            this.btnGestionLibro.Text = "Gestionar Libros";
            this.btnGestionLibro.UseVisualStyleBackColor = true;
            this.btnGestionLibro.Click += new System.EventHandler(this.btnGestionLibro_Click);
            // 
            // btnGestionMiembro
            // 
            this.btnGestionMiembro.Location = new System.Drawing.Point(50, 100);
            this.btnGestionMiembro.Name = "btnGestionMiembro";
            this.btnGestionMiembro.Size = new System.Drawing.Size(150, 30);
            this.btnGestionMiembro.TabIndex = 1;
            this.btnGestionMiembro.Text = "Gestionar Miembros";
            this.btnGestionMiembro.UseVisualStyleBackColor = true;
            this.btnGestionMiembro.Click += new System.EventHandler(this.btnGestionMiembro_Click);
            // 
            // btnGestionPrestamo
            // 
            this.btnGestionPrestamo.Location = new System.Drawing.Point(50, 150);
            this.btnGestionPrestamo.Name = "btnGestionPrestamo";
            this.btnGestionPrestamo.Size = new System.Drawing.Size(150, 30);
            this.btnGestionPrestamo.TabIndex = 2;
            this.btnGestionPrestamo.Text = "Gestionar Préstamos";
            this.btnGestionPrestamo.UseVisualStyleBackColor = true;
            this.btnGestionPrestamo.Click += new System.EventHandler(this.btnGestionPrestamo_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGestionPrestamo);
            this.Controls.Add(this.btnGestionMiembro);
            this.Controls.Add(this.btnGestionLibro);
            this.Name = "MainForm";
            this.Text = "Biblioteca Los Inge";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnGestionLibro;
        private System.Windows.Forms.Button btnGestionMiembro;
        private System.Windows.Forms.Button btnGestionPrestamo;
    }
}
