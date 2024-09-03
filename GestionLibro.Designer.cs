partial class GestionLibro
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ListBox lstLibros;
    private System.Windows.Forms.TextBox txtTitulo;
    private System.Windows.Forms.TextBox txtAutor;
    private System.Windows.Forms.TextBox txtAñoPublicacion;
    private System.Windows.Forms.Button btnAgregarLibro;
    private System.Windows.Forms.Button btnEliminarLibro;
    private System.Windows.Forms.Button btnModificarLibro;

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
        this.lstLibros = new System.Windows.Forms.ListBox();
        this.txtTitulo = new System.Windows.Forms.TextBox();
        this.txtAutor = new System.Windows.Forms.TextBox();
        this.txtAñoPublicacion = new System.Windows.Forms.TextBox();
        this.btnAgregarLibro = new System.Windows.Forms.Button();
        this.btnEliminarLibro = new System.Windows.Forms.Button();
        this.btnModificarLibro = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lstLibros
        // 
        this.lstLibros.FormattingEnabled = true;
        this.lstLibros.ItemHeight = 16;
        this.lstLibros.Location = new System.Drawing.Point(12, 12);
        this.lstLibros.Name = "lstLibros";
        this.lstLibros.Size = new System.Drawing.Size(400, 180);
        this.lstLibros.TabIndex = 0;
        this.lstLibros.SelectedIndexChanged += new System.EventHandler(this.lstLibros_SelectedIndexChanged);
        // 
        // txtTitulo
        // 
        this.txtTitulo.Location = new System.Drawing.Point(12, 210);
        this.txtTitulo.Name = "txtTitulo";
        this.txtTitulo.Size = new System.Drawing.Size(200, 22);
        this.txtTitulo.TabIndex = 1;
        this.txtTitulo.PlaceholderText = "Título del libro";
        // 
        // txtAutor
        // 
        this.txtAutor.Location = new System.Drawing.Point(12, 240);
        this.txtAutor.Name = "txtAutor";
        this.txtAutor.Size = new System.Drawing.Size(200, 22);
        this.txtAutor.TabIndex = 2;
        this.txtAutor.PlaceholderText = "Autor del libro";
        // 
        // txtAñoPublicacion
        // 
        this.txtAñoPublicacion.Location = new System.Drawing.Point(12, 270);
        this.txtAñoPublicacion.Name = "txtAñoPublicacion";
        this.txtAñoPublicacion.Size = new System.Drawing.Size(200, 22);
        this.txtAñoPublicacion.TabIndex = 3;
        this.txtAñoPublicacion.PlaceholderText = "Año de publicación";
        // 
        // btnAgregarLibro
        // 
        this.btnAgregarLibro.Location = new System.Drawing.Point(220, 210);
        this.btnAgregarLibro.Name = "btnAgregarLibro";
        this.btnAgregarLibro.Size = new System.Drawing.Size(75, 30);
        this.btnAgregarLibro.TabIndex = 4;
        this.btnAgregarLibro.Text = "Agregar";
        this.btnAgregarLibro.UseVisualStyleBackColor = true;
        this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
        // 
        // btnEliminarLibro
        // 
        this.btnEliminarLibro.Location = new System.Drawing.Point(220, 250);
        this.btnEliminarLibro.Name = "btnEliminarLibro";
        this.btnEliminarLibro.Size = new System.Drawing.Size(75, 30);
        this.btnEliminarLibro.TabIndex = 5;
        this.btnEliminarLibro.Text = "Eliminar";
        this.btnEliminarLibro.UseVisualStyleBackColor = true;
        this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
        // 
        // btnModificarLibro
        // 
        this.btnModificarLibro.Location = new System.Drawing.Point(220, 290);
        this.btnModificarLibro.Name = "btnModificarLibro";
        this.btnModificarLibro.Size = new System.Drawing.Size(75, 30);
        this.btnModificarLibro.TabIndex = 6;
        this.btnModificarLibro.Text = "Modificar";
        this.btnModificarLibro.UseVisualStyleBackColor = true;
        this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarLibro_Click);
        // 
        // GestionLibro
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(424, 331);
        this.Controls.Add(this.btnModificarLibro);
        this.Controls.Add(this.btnEliminarLibro);
        this.Controls.Add(this.btnAgregarLibro);
        this.Controls.Add(this.txtAñoPublicacion);
        this.Controls.Add(this.txtAutor);
        this.Controls.Add(this.txtTitulo);
        this.Controls.Add(this.lstLibros);
        this.Name = "GestionLibro";
        this.Text = "Gestión de Libros";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
