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
        string texto = libro is LibroFisico libroFisico
            ? $"Título: {libroFisico.Titulo}, Autor: {libroFisico.Autor}, Año: {libroFisico.AñoPublicacion}, Tipo: Físico ({libroFisico.Cantidad})"
            : libro is LibroElectronico libroElectronico
            ? $"Título: {libroElectronico.Titulo}, Autor: {libroElectronico.Autor}, Año: {libroElectronico.AñoPublicacion}, Tipo: Electrónico ({libroElectronico.Formato})"
            : $"Título: {libro.Titulo}, Autor: {libro.Autor}, Año: {libro.AñoPublicacion}";

        lstLibros.Items.Add(texto);
    }

    private void CargarTiposDeLibro()
    {
        cboTipoLibro.Items.Clear();
        cboTipoLibro.Items.Add("Físico");
        cboTipoLibro.Items.Add("Electrónico - PDF");
        cboTipoLibro.Items.Add("Electrónico - URL");
        cboTipoLibro.SelectedIndex = 0; // Selecciona "Físico" por defecto
    }

    private void btnAgregarLibro_Click(object sender, EventArgs e)
    {
        string titulo = txtTitulo.Text;
        string autor = txtAutor.Text;
        string tipoLibro = cboTipoLibro.SelectedItem.ToString();

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

        if (tipoLibro == "Físico")
        {
            bool libroExistente = false;
            foreach (Libro libro in DataManager.Instance.ObtenerLibros())
            {
                if (libro is LibroFisico libroFisico &&
                    libroFisico.Titulo == titulo &&
                    libroFisico.Autor == autor &&
                    libroFisico.AñoPublicacion == añoPublicacion)
                {
                    libroExistente = true;
                    libroFisico.Cantidad++;
                    MessageBox.Show($"El libro físico '{titulo}' ya existe. La cantidad ha sido incrementada a {libroFisico.Cantidad}.");
                    ActualizarListaLibros();
                    return;
                }
            }

            if (!libroExistente)
            {
                LibroFisico nuevoLibroFisico = new LibroFisico(titulo, autor, añoPublicacion, 1);
                DataManager.Instance.AgregarLibro(nuevoLibroFisico);
                MostrarLibroEnLista(nuevoLibroFisico);
            }
        }
        else if (tipoLibro == "Electrónico - PDF" || tipoLibro == "Electrónico - URL")
        {
            string formato = tipoLibro == "Electrónico - PDF" ? "PDF" : "URL";
            bool libroExistente = false;
            foreach (Libro libro in DataManager.Instance.ObtenerLibros())
            {
                if (libro is LibroElectronico libroElectronico &&
                    libroElectronico.Titulo == titulo &&
                    libroElectronico.Autor == autor &&
                    libroElectronico.AñoPublicacion == añoPublicacion &&
                    libroElectronico.Formato == formato)
                {
                    libroExistente = true;
                    MessageBox.Show($"El libro electrónico '{titulo}' ya existe en formato {formato}. No es necesario agregarlo nuevamente.");
                    return;
                }
            }

            if (!libroExistente)
            {
                LibroElectronico nuevoLibroElectronico = new LibroElectronico(titulo, autor, añoPublicacion, formato);
                DataManager.Instance.AgregarLibro(nuevoLibroElectronico);
                MostrarLibroEnLista(nuevoLibroElectronico);
            }
        }

        LimpiarCampos();
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
                    ActualizarListaLibros();
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

            // Actualizar la información del libro
            libroSeleccionado.Titulo = titulo;
            libroSeleccionado.Autor = autor;
            libroSeleccionado.AñoPublicacion = añoPublicacion;

            if (libroSeleccionado is LibroElectronico libroElectronico)
            {
                libroElectronico.Formato = tipoLibro.Contains("URL") ? "URL" : "PDF";
            }

            ActualizarListaLibros();
            LimpiarCampos();
        }
        else
        {
            MessageBox.Show("Seleccione un libro para modificar.");
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
        string textoSeleccionado = (string)lstLibros.SelectedItem;

        if (!string.IsNullOrEmpty(textoSeleccionado))
        {
            foreach (Libro libro in DataManager.Instance.ObtenerLibros())
            {
                string textoLibro = libro is LibroFisico libroFisico
                    ? $"Título: {libroFisico.Titulo}, Autor: {libroFisico.Autor}, Año: {libroFisico.AñoPublicacion}, Tipo: Físico ({libroFisico.Cantidad})"
                    : libro is LibroElectronico libroElectronico
                    ? $"Título: {libroElectronico.Titulo}, Autor: {libroElectronico.Autor}, Año: {libroElectronico.AñoPublicacion}, Tipo: Electrónico ({libroElectronico.Formato})"
                    : $"Título: {libro.Titulo}, Autor: {libro.Autor}, Año: {libro.AñoPublicacion}";

                if (textoSeleccionado == textoLibro)
                {
                    libroSeleccionado = libro;
                    txtTitulo.Text = libro.Titulo;
                    txtAutor.Text = libro.Autor;
                    txtAñoPublicacion.Text = libro.AñoPublicacion.ToString();
                    cboTipoLibro.SelectedItem = libro is LibroFisico ? "Físico" : libro is LibroElectronico libroElectronicoURL ? libroElectronicoURL.Formato == "PDF" ? "Electrónico - PDF" : "Electrónico - URL" : "Físico";
                    break;
                }
            }
        }
    }

    private void TxtAñoPublicacion_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Solo permitir números
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }
}
