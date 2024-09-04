using System;
using System.Windows.Forms;

namespace BibliotecaLosInge
{
    public partial class GestionPrestamo : Form
    {
        private Prestamo prestamoSeleccionado;

        public GestionPrestamo()
        {
            InitializeComponent();
            CargarLibros();
            CargarMiembros();
            CargarTipoLibros();
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            Libro libroSeleccionado = cboTituloLibro.SelectedItem as Libro;
            Miembro miembroSeleccionado = cboNombreMiembro.SelectedItem as Miembro;
            DateTime fechaSalida = dtpFechaSalida.Value;
            DateTime fechaDevolucion = dtpFechaDevolucion.Value;
            string tipoLibro = cboTipoLibro.SelectedItem?.ToString();

            if (libroSeleccionado != null && miembroSeleccionado != null && !string.IsNullOrEmpty(tipoLibro))
            {
                bool esElectronico = tipoLibro == "Libro electrónico";
                Prestamo prestamo = new Prestamo(miembroSeleccionado, libroSeleccionado, fechaSalida, fechaDevolucion, esElectronico);
                DataManager.Instance.AgregarPrestamo(prestamo);
                lstPrestamos.Items.Add(prestamo);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro, un miembro y un tipo de libro.");
            }
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            if (lstPrestamos.SelectedItem != null)
            {
                Prestamo prestamoSeleccionado = lstPrestamos.SelectedItem as Prestamo;
                DataManager.Instance.EliminarPrestamo(prestamoSeleccionado);
                lstPrestamos.Items.Remove(prestamoSeleccionado);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un préstamo para eliminar.");
            }
        }

        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            if (lstPrestamos.SelectedItem != null)
            {
                prestamoSeleccionado = lstPrestamos.SelectedItem as Prestamo;
                cboNombreMiembro.SelectedItem = prestamoSeleccionado.Miembro;
                cboTituloLibro.SelectedItem = prestamoSeleccionado.Libro;
                dtpFechaSalida.Value = prestamoSeleccionado.FechaSalida;
                dtpFechaDevolucion.Value = prestamoSeleccionado.FechaDevolucion;
                cboTipoLibro.SelectedItem = prestamoSeleccionado.EsElectronico ? "Libro electrónico" : "Libro físico";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un préstamo para modificar.");
            }
        }

        private void CargarLibros()
        {
            cboTituloLibro.DataSource = new BindingSource(DataManager.Instance.ObtenerLibros(), null);
            cboTituloLibro.DisplayMember = "Titulo";
        }

        private void CargarMiembros()
        {
            cboNombreMiembro.DataSource = new BindingSource(DataManager.Instance.ObtenerMiembros(), null);
            cboNombreMiembro.DisplayMember = "Nombre";
        }

        private void CargarTipoLibros()
        {
            cboTipoLibro.DataSource = new BindingSource(new[] { "Libro electrónico", "Libro físico" }, null);
        }

        private void ClearFields()
        {
            cboNombreMiembro.SelectedIndex = -1;
            cboTituloLibro.SelectedIndex = -1;
            dtpFechaSalida.Value = DateTime.Now;
            dtpFechaDevolucion.Value = DateTime.Now;
            cboTipoLibro.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Método vacío
        }

        private void FechaEntrega_Click(object sender, EventArgs e)
        {
            // Método vacío
        }
    }
}
