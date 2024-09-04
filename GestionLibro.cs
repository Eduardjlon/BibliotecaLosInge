using BibliotecaLosInge;
using System;
using System.Windows.Forms;

public partial class GestionLibro : Form
{
    private Libro libroSeleccionado = null;

    public GestionLibro()
    {
        InitializeComponent();
        CargarLibros();
    }

    private void CargarLibros()
    {
        lstLibros.Items.Clear();
        foreach (Libro libro in DataManager.Instance.ObtenerLibros())
        {
            lstLibros.Items.Add(libro);
        }
    }

    private void btnAgregarLibro_Click(object sender, EventArgs e)
    {
        string titulo = txtTitulo.Text;
        string autor = txtAutor.Text;
        if (int.TryParse(txtAñoPublicacion.Text, out int añoPublicacion))
        {
            Libro libro = new Libro(titulo, autor, añoPublicacion);
            DataManager.Instance.AgregarLibro(libro);
            lstLibros.Items.Add(libro);
            LimpiarCampos();
        }
        else
        {
            MessageBox.Show("Por favor, ingrese un año válido.");
        }
    }

    private void btnEliminarLibro_Click(object sender, EventArgs e)
    {
        Libro libroSeleccionado = lstLibros.SelectedItem as Libro;
        if (libroSeleccionado != null)
        {
            DataManager.Instance.EliminarLibro(libroSeleccionado);
            lstLibros.Items.Remove(libroSeleccionado);
            LimpiarCampos();
        }
        else
        {
            MessageBox.Show("Seleccione un libro para eliminar.");
        }
    }

    private void btnModificarLibro_Click(object sender, EventArgs e)
    {
        if (libroSeleccionado != null)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            if (int.TryParse(txtAñoPublicacion.Text, out int añoPublicacion))
            {
                libroSeleccionado.Titulo = titulo;
                libroSeleccionado.Autor = autor;
                libroSeleccionado.AñoPublicacion = añoPublicacion;

                // Actualizar el libro en la lista
                int index = lstLibros.SelectedIndex;
                lstLibros.Items[index] = libroSeleccionado;
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un año válido.");
            }
        }
        else
        {
            MessageBox.Show("Seleccione un libro para modificar.");
        }
    }

    private void LimpiarCampos()
    {
        txtTitulo.Clear();
        txtAutor.Clear();
        txtAñoPublicacion.Clear();
        libroSeleccionado = null;
    }

    private void lstLibros_SelectedIndexChanged(object sender, EventArgs e)
    {
        libroSeleccionado = lstLibros.SelectedItem as Libro;
        if (libroSeleccionado != null)
        {
            txtTitulo.Text = libroSeleccionado.Titulo;
            txtAutor.Text = libroSeleccionado.Autor;
            txtAñoPublicacion.Text = libroSeleccionado.AñoPublicacion.ToString();
        }
    }
}
