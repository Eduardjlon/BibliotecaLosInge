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

        // Configuración de txtNumeroMiembro
        txtNumeroMiembro.MaxLength = 4; // Limitar a 4 caracteres
        txtNumeroMiembro.KeyPress += TxtNumeroMiembro_KeyPress; // Solo permitir números
        txtNumeroMiembro.TextChanged += TxtNumeroMiembro_TextChanged; // Verificar longitud
    }

    private void CargarMiembros()
    {
        lstMiembros.Items.Clear();
        foreach (Miembro miembro in DataManager.Instance.ObtenerMiembros())
        {
            lstMiembros.Items.Add(miembro);
        }
    }

    private void btnAgregarMiembro_Click(object sender, EventArgs e)
    {
        string nombre = txtNombreMiembro.Text;
        string numeroMiembro = txtNumeroMiembro.Text;
        if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(numeroMiembro))
        {
            Miembro miembro = new Miembro(nombre, numeroMiembro);
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
        Miembro miembroSeleccionado = lstMiembros.SelectedItem as Miembro;
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
            string nombre = txtNombreMiembro.Text;
            string numeroMiembro = txtNumeroMiembro.Text;
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

    private void TxtNumeroMiembro_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Permite solo números y la tecla de retroceso
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // Cancela el evento de tecla
        }
    }

    private void TxtNumeroMiembro_TextChanged(object sender, EventArgs e)
    {
        // Verifica si el texto tiene más de 4 caracteres y recorta el texto si es necesario
        if (txtNumeroMiembro.Text.Length > 4)
        {
            txtNumeroMiembro.Text = txtNumeroMiembro.Text.Substring(0, 4);
            txtNumeroMiembro.SelectionStart = txtNumeroMiembro.Text.Length; // Mueve el cursor al final
        }
    }
}
