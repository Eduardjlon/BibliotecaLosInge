partial class GestionMiembro
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ListBox lstMiembros;
    private System.Windows.Forms.TextBox txtNombreMiembro;
    private System.Windows.Forms.TextBox txtNumeroMiembro;
    private System.Windows.Forms.Button btnAgregarMiembro;
    private System.Windows.Forms.Button btnEliminarMiembro;
    private System.Windows.Forms.Button btnModificarMiembro;

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
        lstMiembros = new ListBox();
        txtNombreMiembro = new TextBox();
        txtNumeroMiembro = new TextBox();
        btnAgregarMiembro = new Button();
        btnEliminarMiembro = new Button();
        btnModificarMiembro = new Button();
        SuspendLayout();
        // 
        // lstMiembros
        // 
        lstMiembros.BackColor = Color.Aqua;
        lstMiembros.ForeColor = SystemColors.ActiveCaptionText;
        lstMiembros.FormattingEnabled = true;
        lstMiembros.ItemHeight = 15;
        lstMiembros.Location = new Point(10, 11);
        lstMiembros.Name = "lstMiembros";
        lstMiembros.Size = new Size(350, 169);
        lstMiembros.TabIndex = 0;
        lstMiembros.SelectedIndexChanged += lstMiembros_SelectedIndexChanged;
        // 
        // txtNombreMiembro
        // 
        txtNombreMiembro.BackColor = Color.Aquamarine;
        txtNombreMiembro.Location = new Point(10, 197);
        txtNombreMiembro.Name = "txtNombreMiembro";
        txtNombreMiembro.PlaceholderText = "Nombre del miembro";
        txtNombreMiembro.Size = new Size(176, 23);
        txtNombreMiembro.TabIndex = 1;
        // 
        // txtNumeroMiembro
        // 
        txtNumeroMiembro.BackColor = Color.Aquamarine;
        txtNumeroMiembro.Location = new Point(10, 225);
        txtNumeroMiembro.Name = "txtNumeroMiembro";
        txtNumeroMiembro.PlaceholderText = "Número de miembro";
        txtNumeroMiembro.Size = new Size(176, 23);
        txtNumeroMiembro.TabIndex = 2;
        txtNumeroMiembro.KeyPress += txtNumeroMiembro_KeyPress;
        // 
        // btnAgregarMiembro
        // 
        btnAgregarMiembro.BackColor = Color.ForestGreen;
        btnAgregarMiembro.Location = new Point(192, 197);
        btnAgregarMiembro.Name = "btnAgregarMiembro";
        btnAgregarMiembro.Size = new Size(66, 28);
        btnAgregarMiembro.TabIndex = 3;
        btnAgregarMiembro.Text = "Agregar";
        btnAgregarMiembro.UseVisualStyleBackColor = false;
        btnAgregarMiembro.Click += btnAgregarMiembro_Click;
        // 
        // btnEliminarMiembro
        // 
        btnEliminarMiembro.BackColor = Color.Red;
        btnEliminarMiembro.ForeColor = Color.Cornsilk;
        btnEliminarMiembro.Location = new Point(192, 234);
        btnEliminarMiembro.Name = "btnEliminarMiembro";
        btnEliminarMiembro.Size = new Size(66, 28);
        btnEliminarMiembro.TabIndex = 4;
        btnEliminarMiembro.Text = "Eliminar";
        btnEliminarMiembro.UseVisualStyleBackColor = false;
        btnEliminarMiembro.Click += btnEliminarMiembro_Click;
        // 
        // btnModificarMiembro
        // 
        btnModificarMiembro.BackColor = Color.Cyan;
        btnModificarMiembro.Location = new Point(192, 272);
        btnModificarMiembro.Name = "btnModificarMiembro";
        btnModificarMiembro.Size = new Size(66, 28);
        btnModificarMiembro.TabIndex = 5;
        btnModificarMiembro.Text = "Modificar";
        btnModificarMiembro.UseVisualStyleBackColor = false;
        btnModificarMiembro.Click += btnModificarMiembro_Click;
        // 
        // GestionMiembro
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(589, 310);
        Controls.Add(btnModificarMiembro);
        Controls.Add(btnEliminarMiembro);
        Controls.Add(btnAgregarMiembro);
        Controls.Add(txtNumeroMiembro);
        Controls.Add(txtNombreMiembro);
        Controls.Add(lstMiembros);
        Name = "GestionMiembro";
        Text = "Gestión de Miembros";
        ResumeLayout(false);
        PerformLayout();
    }
}
