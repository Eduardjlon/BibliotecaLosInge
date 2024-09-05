using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

partial class GestionMiembro
{
    private System.ComponentModel.IContainer components = null;
    private ListBox lstMiembros;
    private TextBox txtNombreMiembro;
    private TextBox txtNumeroMiembro;
    private Button btnAgregarMiembro;
    private Button btnEliminarMiembro;
    private Button btnModificarMiembro;

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
        this.lstMiembros = new ListBox();
        this.txtNombreMiembro = new TextBox();
        this.txtNumeroMiembro = new TextBox();
        this.btnAgregarMiembro = new Button();
        this.btnEliminarMiembro = new Button();
        this.btnModificarMiembro = new Button();
        this.SuspendLayout();

        // 
        // lstMiembros
        // 
        this.lstMiembros.BackColor = Color.Aqua;
        this.lstMiembros.ForeColor = SystemColors.ActiveCaptionText;
        this.lstMiembros.FormattingEnabled = true;
        this.lstMiembros.ItemHeight = 15;
        this.lstMiembros.Location = new Point(10, 11);
        this.lstMiembros.Name = "lstMiembros";
        this.lstMiembros.Size = new Size(350, 169);
        this.lstMiembros.TabIndex = 0;
        this.lstMiembros.SelectedIndexChanged += new EventHandler(this.lstMiembros_SelectedIndexChanged);

        // 
        // txtNombreMiembro
        // 
        this.txtNombreMiembro.BackColor = Color.Aquamarine;
        this.txtNombreMiembro.Location = new Point(10, 197);
        this.txtNombreMiembro.Name = "txtNombreMiembro";
        this.txtNombreMiembro.PlaceholderText = "Nombre del miembro";
        this.txtNombreMiembro.Size = new Size(176, 23);
        this.txtNombreMiembro.TabIndex = 1;

        // 
        // txtNumeroMiembro
        // 
        this.txtNumeroMiembro.BackColor = Color.Aquamarine;
        this.txtNumeroMiembro.Location = new Point(10, 225);
        this.txtNumeroMiembro.Name = "txtNumeroMiembro";
        this.txtNumeroMiembro.PlaceholderText = "Número de miembro";
        this.txtNumeroMiembro.Size = new Size(176, 23);
        this.txtNumeroMiembro.TabIndex = 2;
        this.txtNumeroMiembro.KeyPress += new KeyPressEventHandler(this.TxtNumeroMiembro_KeyPress);

        // 
        // btnAgregarMiembro
        // 
        this.btnAgregarMiembro.BackColor = Color.ForestGreen;
        this.btnAgregarMiembro.Location = new Point(192, 197);
        this.btnAgregarMiembro.Name = "btnAgregarMiembro";
        this.btnAgregarMiembro.Size = new Size(66, 28);
        this.btnAgregarMiembro.TabIndex = 3;
        this.btnAgregarMiembro.Text = "Agregar";
        this.btnAgregarMiembro.UseVisualStyleBackColor = false;
        this.btnAgregarMiembro.Click += new EventHandler(this.btnAgregarMiembro_Click);

        // 
        // btnEliminarMiembro
        // 
        this.btnEliminarMiembro.BackColor = Color.Red;
        this.btnEliminarMiembro.ForeColor = Color.Cornsilk;
        this.btnEliminarMiembro.Location = new Point(192, 234);
        this.btnEliminarMiembro.Name = "btnEliminarMiembro";
        this.btnEliminarMiembro.Size = new Size(66, 28);
        this.btnEliminarMiembro.TabIndex = 4;
        this.btnEliminarMiembro.Text = "Eliminar";
        this.btnEliminarMiembro.UseVisualStyleBackColor = false;
        this.btnEliminarMiembro.Click += new EventHandler(this.btnEliminarMiembro_Click);

        // 
        // btnModificarMiembro
        // 
        this.btnModificarMiembro.BackColor = Color.Cyan;
        this.btnModificarMiembro.Location = new Point(192, 272);
        this.btnModificarMiembro.Name = "btnModificarMiembro";
        this.btnModificarMiembro.Size = new Size(66, 28);
        this.btnModificarMiembro.TabIndex = 5;
        this.btnModificarMiembro.Text = "Modificar";
        this.btnModificarMiembro.UseVisualStyleBackColor = false;
        this.btnModificarMiembro.Click += new EventHandler(this.btnModificarMiembro_Click);

        // 
        // GestionMiembro
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(589, 310);
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
