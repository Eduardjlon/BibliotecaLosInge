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
        CargarTiposDeLibro();
    }

    private void CargarLibros()
    {
        lstLibros.Items.Clear();
        foreach (Libro libro in DataManager.Instance.ObtenerLibros())
        {
            MostrarLibroEnLista(libro);
        }
    }

    private void MostrarLibroEnLista(Libro libro)
    {
        if (libro is LibroFisico libroFisico)
        {
            // Mostrar título, autor, año y cantidad para libros físicos
            lstLibros.Items.Add($"{libroFisico.Titulo} - {libroFisico.Autor} ({libroFisico.AñoPublicacion}) - Tipo: Físico - Cantidad: {libroFisico.Cantidad}");
        }
        else if (libro is LibroElectronico libroElectronico)
        {
            // Mostrar título, autor, año y formato para libros electrónicos
            lstLibros.Items.Add($"{libroElectronico.Titulo} - {libroElectronico.Autor} ({libroElectronico.AñoPublicacion}) - Tipo: Electrónico - Formato: {libroElectronico.Formato}");
        }
    }

    private void CargarTiposDeLibro()
    {
        cboTipoLibro.Items.Clear();
        cboTipoLibro.Items.Add("Físico");
        cboTipoLibro.Items.Add("Electrónico");
        cboTipoLibro.SelectedIndex = 0; // Selecciona "Físico" por defecto
    }

    private void btnAgregarLibro_Click(object sender, EventArgs e)
    {
        string titulo = txtTitulo.Text;
        string autor = txtAutor.Text;
        string tipoLibro = cboTipoLibro.SelectedItem.ToString();
        string formato = tipoLibro == "Electrónico" ? "PDF" : ""; // Formato por defecto para libros electrónicos

        if (int.TryParse(txtAñoPublicacion.Text, out int añoPublicacion))
        {
            bool libroExistente = false;

            if (tipoLibro == "Físico")
            {
                // Verificar si el libro físico ya existe
                foreach (Libro libro in DataManager.Instance.ObtenerLibros())
                {
                    if (libro is LibroFisico libroFisico &&
                        libroFisico.Titulo == titulo &&
                        libroFisico.Autor == autor &&
                        libroFisico.AñoPublicacion == añoPublicacion)
                    {
                        // Incrementar la cantidad y mostrar mensaje
                        libroFisico.Cantidad++;
                        libroExistente = true;
                        MessageBox.Show($"El libro ya existe. Ahora hay {libroFisico.Cantidad}.");
                        ActualizarListaLibros(); // Actualiza la lista con la nueva cantidad
                        LimpiarCampos(); // Limpia los campos
                        break;
                    }
                }

                if (!libroExistente)
                {
                    // Crear un nuevo libro físico y agregarlo
                    LibroFisico nuevoLibroFisico = new LibroFisico(titulo, autor, añoPublicacion, 1);
                    DataManager.Instance.AgregarLibro(nuevoLibroFisico);
                    lstLibros.Items.Add($"{nuevoLibroFisico.Titulo} - {nuevoLibroFisico.Autor} ({nuevoLibroFisico.AñoPublicacion}) - Tipo: Físico - Cantidad: {nuevoLibroFisico.Cantidad}");
                    LimpiarCampos();
                }
            }
            else if (tipoLibro == "Electrónico")
            {
                // Verificar si el libro electrónico ya existe
                foreach (Libro libro in DataManager.Instance.ObtenerLibros())
                {
                    if (libro is LibroElectronico libroElectronico &&
                        libroElectronico.Titulo == titulo &&
                        libroElectronico.Autor == autor &&
                        libroElectronico.AñoPublicacion == añoPublicacion)
                    {
                        // Mostrar mensaje para libros electrónicos ya existentes
                        libroExistente = true;
                        MessageBox.Show("El libro electrónico ya existe.");
                        LimpiarCampos(); // Limpia los campos
                        break;
                    }
                }

                if (!libroExistente)
                {
                    // Crear un nuevo libro electrónico y agregarlo
                    LibroElectronico nuevoLibroElectronico = new LibroElectronico(titulo, autor, añoPublicacion, formato);
                    DataManager.Instance.AgregarLibro(nuevoLibroElectronico);
                    lstLibros.Items.Add($"{nuevoLibroElectronico.Titulo} - {nuevoLibroElectronico.Autor} ({nuevoLibroElectronico.AñoPublicacion}) - Tipo: Electrónico - Formato: {nuevoLibroElectronico.Formato}");
                    LimpiarCampos();
                }
            }
        }
        else
        {
            MessageBox.Show("Por favor, ingrese un año válido.");
        }
    }

    private void btnEliminarLibro_Click(object sender, EventArgs e)
    {
        libroSeleccionado = lstLibros.SelectedItem as Libro;
        if (libroSeleccionado != null)
        {
            if (libroSeleccionado is LibroFisico libroFisico)
            {
                if (libroFisico.Cantidad > 1)
                {
                    libroFisico.Cantidad--;
                    DataManager.Instance.ActualizarListaLibros();
                    MessageBox.Show($"La cantidad de '{libroFisico.Titulo}' ha sido reducida a {libroFisico.Cantidad}.");
                }
                else
                {
                    DataManager.Instance.EliminarLibro(libroSeleccionado);
                    lstLibros.Items.Remove(libroSeleccionado);
                    LimpiarCampos();
                }
            }
            else
            {
                DataManager.Instance.EliminarLibro(libroSeleccionado);
                lstLibros.Items.Remove(libroSeleccionado);
                LimpiarCampos();
            }
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
            string tipoLibro = cboTipoLibro.SelectedItem.ToString();
            string formato = tipoLibro == "Electrónico" ? "PDF" : ""; // Formato por defecto para libros electrónicos

            if (int.TryParse(txtAñoPublicacion.Text, out int añoPublicacion))
            {
                libroSeleccionado.Titulo = titulo;
                libroSeleccionado.Autor = autor;
                libroSeleccionado.AñoPublicacion = añoPublicacion;
                // Actualizar el tipo y formato si es necesario
                if (libroSeleccionado is LibroElectronico libroElectronico)
                {
                    libroElectronico.Formato = formato;
                }

                // Actualizar el libro en la lista
                int index = lstLibros.SelectedIndex;
                MostrarLibroEnLista(libroSeleccionado); // Actualiza la vista del libro
                lstLibros.Items[index] = $"{libroSeleccionado.Titulo} - {libroSeleccionado.Autor} ({libroSeleccionado.AñoPublicacion}) - Tipo: {(libroSeleccionado is LibroFisico ? "Físico" : "Electrónico")} - {(libroSeleccionado is LibroElectronico libroElec ? $"Formato: {libroElec.Formato}" : $"Cantidad: {(libroSeleccionado as LibroFisico)?.Cantidad}")}";
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
        cboTipoLibro.SelectedIndex = 0; // Reinicia la selección a "Físico"
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
            if (libroSeleccionado is LibroFisico)
            {
                cboTipoLibro.SelectedItem = "Físico";
            }
            else if (libroSeleccionado is LibroElectronico)
            {
                cboTipoLibro.SelectedItem = "Electrónico";
            }
        }
    }

    private void ActualizarListaLibros()
    {
        lstLibros.Items.Clear();
        foreach (Libro libro in DataManager.Instance.ObtenerLibros())
        {
            MostrarLibroEnLista(libro);
        }
    }
}
