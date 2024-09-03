using BibliotecaLosInge;
using System;
using System.Windows.Forms;

public partial class GestionMiembro : Form
{
    private Miembro miembroSeleccionado = null;

    public GestionMiembro()
    {
        InitializeComponent();
        CargarMiembros();
    }

    private void CargarMiembros()
    {
        lstMiembros.Items.Clear();
        foreach (var miembro in DataManager.Instance.ObtenerMiembros())
        {
            lstMiembros.Items.Add(miembro);
        }
    }

    private void btnAgregarMiembro_Click(object sender, EventArgs e)
    {
        var nombre = txtNombreMiembro.Text;
        var numeroMiembro = txtNumeroMiembro.Text;
        if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(numeroMiembro))
        {
            var miembro = new Miembro(nombre, numeroMiembro);
            DataManager.Instance.AgregarMiembro(miembro);
            lstMiembros.Items.Add(miembro);
            LimpiarCampos();
        }
        else
        {
            MessageBox.Show("Por favor, ingrese todos los datos del miembro.");
        }
    }

    private void btnEliminarMiembro_Click(object sender, EventArgs e)
    {
        var miembroSeleccionado = lstMiembros.SelectedItem as Miembro;
        if (miembroSeleccionado != null)
        {
            DataManager.Instance.EliminarMiembro(miembroSeleccionado);
            lstMiembros.Items.Remove(miembroSeleccionado);
            LimpiarCampos();
        }
        else
        {
            MessageBox.Show("Seleccione un miembro para eliminar.");
        }
    }

    private void btnModificarMiembro_Click(object sender, EventArgs e)
    {
        if (miembroSeleccionado != null)
        {
            var nombre = txtNombreMiembro.Text;
            var numeroMiembro = txtNumeroMiembro.Text;
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(numeroMiembro))
            {
                miembroSeleccionado.Nombre = nombre;
                miembroSeleccionado.NumeroMiembro = numeroMiembro;

                // Actualizar el miembro en la lista
                int index = lstMiembros.SelectedIndex;
                lstMiembros.Items[index] = miembroSeleccionado;
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los datos del miembro.");
            }
        }
        else
        {
            MessageBox.Show("Seleccione un miembro para modificar.");
        }
    }

    private void LimpiarCampos()
    {
        txtNombreMiembro.Clear();
        txtNumeroMiembro.Clear();
        miembroSeleccionado = null;
    }

    private void lstMiembros_SelectedIndexChanged(object sender, EventArgs e)
    {
        miembroSeleccionado = lstMiembros.SelectedItem as Miembro;
        if (miembroSeleccionado != null)
        {
            txtNombreMiembro.Text = miembroSeleccionado.Nombre;
            txtNumeroMiembro.Text = miembroSeleccionado.NumeroMiembro;
        }
    }

    private void txtNumeroMiembro_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Permite solo números y la tecla de retroceso
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // Cancela el evento de tecla
        }
    }
}
