partial class GestionLibro
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ListBox lstLibros;
    private System.Windows.Forms.TextBox txtTitulo;
    private System.Windows.Forms.TextBox txtAutor;
    private System.Windows.Forms.TextBox txtAñoPublicacion;
    private System.Windows.Forms.ComboBox cboTipoLibro; 
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
        lstLibros = new ListBox();
        txtTitulo = new TextBox();
        txtAutor = new TextBox();
        txtAñoPublicacion = new TextBox();
        cboTipoLibro = new ComboBox();
        btnAgregarLibro = new Button();
        btnEliminarLibro = new Button();
        btnModificarLibro = new Button();
        SuspendLayout();
        // 
        // lstLibros
        // 
        lstLibros.BackColor = Color.YellowGreen;
        lstLibros.FormattingEnabled = true;
        lstLibros.ItemHeight = 15;
        lstLibros.Location = new Point(10, 11);
        lstLibros.Name = "lstLibros";
        lstLibros.Size = new Size(350, 169);
        lstLibros.TabIndex = 0;
        lstLibros.SelectedIndexChanged += lstLibros_SelectedIndexChanged;
        // 
        // txtTitulo
        // 
        txtTitulo.BackColor = Color.YellowGreen;
        txtTitulo.ForeColor = SystemColors.WindowText;
        txtTitulo.Location = new Point(10, 197);
        txtTitulo.Name = "txtTitulo";
        txtTitulo.PlaceholderText = "Título del libro";
        txtTitulo.Size = new Size(176, 23);
        txtTitulo.TabIndex = 1;
        // 
        // txtAutor
        // 
        txtAutor.BackColor = Color.YellowGreen;
        txtAutor.Location = new Point(10, 225);
        txtAutor.Name = "txtAutor";
        txtAutor.PlaceholderText = "Autor del libro";
        txtAutor.Size = new Size(176, 23);
        txtAutor.TabIndex = 2;
        // 
        // txtAñoPublicacion
        // 
        txtAñoPublicacion.BackColor = Color.YellowGreen;
        txtAñoPublicacion.Location = new Point(10, 253);
        txtAñoPublicacion.Name = "txtAñoPublicacion";
        txtAñoPublicacion.PlaceholderText = "Año de publicación";
        txtAñoPublicacion.Size = new Size(176, 23);
        txtAñoPublicacion.TabIndex = 3;
        // 
        // cboTipoLibro
        // 
        cboTipoLibro.BackColor = Color.YellowGreen;
        cboTipoLibro.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTipoLibro.FormattingEnabled = true;
        cboTipoLibro.Items.AddRange(new object[] { "Físico", "Electrónico" });
        cboTipoLibro.Location = new Point(10, 283);
        cboTipoLibro.Name = "cboTipoLibro";
        cboTipoLibro.Size = new Size(176, 23);
        cboTipoLibro.TabIndex = 4;
        // 
        // btnAgregarLibro
        // 
        btnAgregarLibro.BackColor = Color.ForestGreen;
        btnAgregarLibro.Location = new Point(192, 197);
        btnAgregarLibro.Name = "btnAgregarLibro";
        btnAgregarLibro.Size = new Size(66, 28);
        btnAgregarLibro.TabIndex = 5;
        btnAgregarLibro.Text = "Agregar";
        btnAgregarLibro.UseVisualStyleBackColor = false;
        btnAgregarLibro.Click += btnAgregarLibro_Click;
        // 
        // btnEliminarLibro
        // 
        btnEliminarLibro.BackColor = Color.Red;
        btnEliminarLibro.ForeColor = Color.Cornsilk;
        btnEliminarLibro.Location = new Point(192, 234);
        btnEliminarLibro.Name = "btnEliminarLibro";
        btnEliminarLibro.Size = new Size(66, 28);
        btnEliminarLibro.TabIndex = 6;
        btnEliminarLibro.Text = "Eliminar";
        btnEliminarLibro.UseVisualStyleBackColor = false;
        btnEliminarLibro.Click += btnEliminarLibro_Click;
        // 
        // btnModificarLibro
        // 
        btnModificarLibro.BackColor = Color.LawnGreen;
        btnModificarLibro.ForeColor = Color.Black;
        btnModificarLibro.Location = new Point(192, 272);
        btnModificarLibro.Name = "btnModificarLibro";
        btnModificarLibro.Size = new Size(66, 28);
        btnModificarLibro.TabIndex = 7;
        btnModificarLibro.Text = "Modificar";
        btnModificarLibro.UseVisualStyleBackColor = false;
        btnModificarLibro.Click += btnModificarLibro_Click;
        // 
        // GestionLibro
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlText;
        ClientSize = new Size(371, 310);
        Controls.Add(cboTipoLibro);
        Controls.Add(btnModificarLibro);
        Controls.Add(btnEliminarLibro);
        Controls.Add(btnAgregarLibro);
        Controls.Add(txtAñoPublicacion);
        Controls.Add(txtAutor);
        Controls.Add(txtTitulo);
        Controls.Add(lstLibros);
        ForeColor = SystemColors.ControlLight;
        Name = "GestionLibro";
        Text = "Gestión de Libros";
        ResumeLayout(false);
        PerformLayout();
    }
}
