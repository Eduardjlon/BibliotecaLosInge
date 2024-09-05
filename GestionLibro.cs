using BibliotecaLosInge;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class GestionLibro : Form
{
    private Libro libroSeleccionado = null;

    public GestionLibro()
    {
        InitializeComponent();
        CargarLibros();
        CargarTiposDeLibro();
        txtAñoPublicacion.MaxLength = 4; // Limitar a 4 caracteres
        txtAñoPublicacion.KeyPress += TxtAñoPublicacion_KeyPress; // Solo permitir números
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
            lstLibros.Items.Add($"Título: {libroFisico.Titulo}, Autor: {libroFisico.Autor}, Año: {libroFisico.AñoPublicacion}, Tipo: Físico ({libroFisico.Cantidad})");
        }
        else if (libro is LibroElectronico libroElect)
        {
            lstLibros.Items.Add($"Título: {libroElect.Titulo}, Autor: {libroElect.Autor}, Año: {libroElect.AñoPublicacion}, Tipo: Electrónico ({libroElect.Formato})");
        }
        else
        {
            lstLibros.Items.Add($"Título: {libro.Titulo}, Autor: {libro.Autor}, Año: {libro.AñoPublicacion}");
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

        if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) ||
            string.IsNullOrWhiteSpace(txtAñoPublicacion.Text) || !int.TryParse(txtAñoPublicacion.Text, out _))
        {
            MessageBox.Show("Verifica que todos los campos estén completos y que el año sea válido.");
            return;
        }

        if (txtAñoPublicacion.Text.Length != 4)
        {
            MessageBox.Show("Año inválido. Debe tener exactamente 4 dígitos.");
            return;
        }

        int añoPublicacion = int.Parse(txtAñoPublicacion.Text);
        bool libroExistente = false;

        if (tipoLibro == "Físico")
        {
            foreach (Libro libro in DataManager.Instance.ObtenerLibros())
            {
                if (libro is LibroFisico libroFisico)
                {
                    if (libroFisico.Titulo == titulo &&
                        libroFisico.Autor == autor &&
                        libroFisico.AñoPublicacion == añoPublicacion)
                    {
                        libroFisico.Cantidad++;
                        libroExistente = true;
                        MessageBox.Show($"El libro ya existe. Ahora hay {libroFisico.Cantidad}.");
                        ActualizarListaLibros(); // Actualiza la lista con la nueva cantidad
                        LimpiarCampos(); // Limpia los campos
                        break;
                    }
                }
            }

            if (!libroExistente)
            {
                LibroFisico nuevoLibroFisico = new LibroFisico(titulo, autor, añoPublicacion, 1);
                DataManager.Instance.AgregarLibro(nuevoLibroFisico);
                lstLibros.Items.Add($"Título: {nuevoLibroFisico.Titulo}, Autor: {nuevoLibroFisico.Autor}, Año: {nuevoLibroFisico.AñoPublicacion}, Tipo: Físico ({nuevoLibroFisico.Cantidad})");
                LimpiarCampos();
            }
        }
        else if (tipoLibro == "Electrónico")
        {
            foreach (Libro libro in DataManager.Instance.ObtenerLibros())
            {
                if (libro is LibroElectronico libroElect)
                {
                    if (libroElect.Titulo == titulo &&
                        libroElect.Autor == autor &&
                        libroElect.AñoPublicacion == añoPublicacion)
                    {
                        libroExistente = true;
                        MessageBox.Show("El libro electrónico ya existe.");
                        LimpiarCampos(); // Limpia los campos
                        break;
                    }
                }
            }

            if (!libroExistente)
            {
                LibroElectronico nuevoLibroElectronico = new LibroElectronico(titulo, autor, añoPublicacion, formato);
                DataManager.Instance.AgregarLibro(nuevoLibroElectronico);
                lstLibros.Items.Add($"Título: {nuevoLibroElectronico.Titulo}, Autor: {nuevoLibroElectronico.Autor}, Año: {nuevoLibroElectronico.AñoPublicacion}, Tipo: Electrónico ({nuevoLibroElectronico.Formato})");
                LimpiarCampos();
            }
        }
    }

    private void btnEliminarLibro_Click(object sender, EventArgs e)
    {
        if (libroSeleccionado != null)
        {
            if (libroSeleccionado is LibroFisico libroFisico)
            {
                if (libroFisico.Cantidad > 1)
                {
                    libroFisico.Cantidad--;
                    MessageBox.Show($"La cantidad de '{libroFisico.Titulo}' ha sido reducida a {libroFisico.Cantidad}.");
                    ActualizarListaLibros(); // Actualiza la lista con la nueva cantidad
                }
                else
                {
                    DataManager.Instance.EliminarLibro(libroSeleccionado);
                    lstLibros.Items.Remove(lstLibros.SelectedItem);
                    LimpiarCampos();
                }
            }
            else
            {
                DataManager.Instance.EliminarLibro(libroSeleccionado);
                lstLibros.Items.Remove(lstLibros.SelectedItem);
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

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) ||
                string.IsNullOrWhiteSpace(txtAñoPublicacion.Text) || !int.TryParse(txtAñoPublicacion.Text, out _))
            {
                MessageBox.Show("Verifica que todos los campos estén completos y que el año sea válido.");
                return;
            }

            if (txtAñoPublicacion.Text.Length != 4)
            {
                MessageBox.Show("Año inválido. Debe tener exactamente 4 dígitos.");
                return;
            }

            int añoPublicacion = int.Parse(txtAñoPublicacion.Text);
            libroSeleccionado.Titulo = titulo;
            libroSeleccionado.Autor = autor;
            libroSeleccionado.AñoPublicacion = añoPublicacion;

            if (libroSeleccionado is LibroElectronico libroElect)
            {
                libroElect.Formato = formato;
            }

            ActualizarListaLibros();
            LimpiarCampos();
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
        string textoSeleccionado = lstLibros.SelectedItem as string;
        if (textoSeleccionado != null)
        {
            foreach (Libro libro in DataManager.Instance.ObtenerLibros())
            {
                string textoLibro = libro is LibroFisico libroFisico
                    ? $"Título: {libroFisico.Titulo}, Autor: {libroFisico.Autor}, Año: {libroFisico.AñoPublicacion}, Tipo: Físico ({libroFisico.Cantidad})"
                    : libro is LibroElectronico libroElect
                    ? $"Título: {libroElect.Titulo}, Autor: {libroElect.Autor}, Año: {libroElect.AñoPublicacion}, Tipo: Electrónico ({libroElect.Formato})"
                    : $"Título: {libro.Titulo}, Autor: {libro.Autor}, Año: {libro.AñoPublicacion}";

                if (textoLibro == textoSeleccionado)
                {
                    libroSeleccionado = libro;
                    txtTitulo.Text = libro.Titulo;
                    txtAutor.Text = libro.Autor;
                    txtAñoPublicacion.Text = libro.AñoPublicacion.ToString();
                    if (libro is LibroFisico)
                    {
                        cboTipoLibro.SelectedItem = "Físico";
                    }
                    else if (libro is LibroElectronico)
                    {
                        cboTipoLibro.SelectedItem = "Electrónico";
                    }
                    break;
                }
            }
        }
    }

    private void TxtAñoPublicacion_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Solo permitir la entrada de números
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
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
