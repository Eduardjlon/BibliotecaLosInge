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
        this.lstMiembros = new System.Windows.Forms.ListBox();
        this.txtNombreMiembro = new System.Windows.Forms.TextBox();
        this.txtNumeroMiembro = new System.Windows.Forms.TextBox();
        this.btnAgregarMiembro = new System.Windows.Forms.Button();
        this.btnEliminarMiembro = new System.Windows.Forms.Button();
        this.btnModificarMiembro = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lstMiembros
        // 
        this.lstMiembros.FormattingEnabled = true;
        this.lstMiembros.ItemHeight = 16;
        this.lstMiembros.Location = new System.Drawing.Point(12, 12);
        this.lstMiembros.Name = "lstMiembros";
        this.lstMiembros.Size = new System.Drawing.Size(400, 180);
        this.lstMiembros.TabIndex = 0;
        this.lstMiembros.SelectedIndexChanged += new System.EventHandler(this.lstMiembros_SelectedIndexChanged);
        // 
        // txtNombreMiembro
        // 
        this.txtNombreMiembro.Location = new System.Drawing.Point(12, 210);
        this.txtNombreMiembro.Name = "txtNombreMiembro";
        this.txtNombreMiembro.Size = new System.Drawing.Size(200, 22);
        this.txtNombreMiembro.TabIndex = 1;
        this.txtNombreMiembro.PlaceholderText = "Nombre del miembro";
        // 
        // txtNumeroMiembro
        // 
        this.txtNumeroMiembro.Location = new System.Drawing.Point(12, 240);
        this.txtNumeroMiembro.Name = "txtNumeroMiembro";
        this.txtNumeroMiembro.Size = new System.Drawing.Size(200, 22);
        this.txtNumeroMiembro.TabIndex = 2;
        this.txtNumeroMiembro.PlaceholderText = "Número de miembro";
        this.txtNumeroMiembro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroMiembro_KeyPress);
        // 
        // btnAgregarMiembro
        // 
        this.btnAgregarMiembro.Location = new System.Drawing.Point(220, 210);
        this.btnAgregarMiembro.Name = "btnAgregarMiembro";
        this.btnAgregarMiembro.Size = new System.Drawing.Size(75, 30);
        this.btnAgregarMiembro.TabIndex = 3;
        this.btnAgregarMiembro.Text = "Agregar";
        this.btnAgregarMiembro.UseVisualStyleBackColor = true;
        this.btnAgregarMiembro.Click += new System.EventHandler(this.btnAgregarMiembro_Click);
        // 
        // btnEliminarMiembro
        // 
        this.btnEliminarMiembro.Location = new System.Drawing.Point(220, 250);
        this.btnEliminarMiembro.Name = "btnEliminarMiembro";
        this.btnEliminarMiembro.Size = new System.Drawing.Size(75, 30);
        this.btnEliminarMiembro.TabIndex = 4;
        this.btnEliminarMiembro.Text = "Eliminar";
        this.btnEliminarMiembro.UseVisualStyleBackColor = true;
        this.btnEliminarMiembro.Click += new System.EventHandler(this.btnEliminarMiembro_Click);
        // 
        // btnModificarMiembro
        // 
        this.btnModificarMiembro.Location = new System.Drawing.Point(220, 290);
        this.btnModificarMiembro.Name = "btnModificarMiembro";
        this.btnModificarMiembro.Size = new System.Drawing.Size(75, 30);
        this.btnModificarMiembro.TabIndex = 5;
        this.btnModificarMiembro.Text = "Modificar";
        this.btnModificarMiembro.UseVisualStyleBackColor = true;
        this.btnModificarMiembro.Click += new System.EventHandler(this.btnModificarMiembro_Click);
        // 
        // GestionMiembro
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(424, 331);
        this.Controls.Add(this.btnModificarMiembro);
        this.Controls.Add(this.btnEliminarMiembro);
        this.Controls.Add(this.btnAgregarMiembro);
        this.Controls.Add(this.txtNumeroMiembro);
        this.Controls.Add(this.txtNombreMiembro);
        this.Controls.Add(this.lstMiembros);
        this.Name = "GestionMiembro";
        this.Text = "Gestión de Miembros";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
