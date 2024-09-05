using System;
using System.Windows.Forms;

namespace BibliotecaLosInge
{
    public partial class GestionPrestamo : Form
    {
        private DataManager _dataManager;

        public GestionPrestamo()
        {
            InitializeComponent();
            _dataManager = DataManager.Instance; // Singleton
            CargarMiembros();
            CargarLibros();
            InicializarControles();
        }

        private void InicializarControles()
        {
            // Agregar opciones al comboBoxTipoLibro
            cboTipoLibro.Items.Add("Seleccione el tipo de libro");
            cboTipoLibro.Items.Add("Libro Físico");
            cboTipoLibro.Items.Add("Libro Electrónico");
            cboTipoLibro.SelectedIndex = 0; // Seleccionar la opción por defecto
            ListFisico.Enabled = false;
            ListElectronico.Enabled = false;
        }

        private void CargarMiembros()
        {
            cboNombreMiembro.Items.Clear();
            foreach (Miembro miembro in _dataManager.ObtenerMiembros())
            {
                cboNombreMiembro.Items.Add(miembro);
            }
        }

        private void CargarLibros()
        {
            ListFisico.Items.Clear();
            ListElectronico.Items.Clear();

            foreach (Libro libro in _dataManager.ObtenerLibros())
            {
                if (libro is LibroFisico)
                {
                    ListFisico.Items.Add(libro);
                }
                else if (libro is LibroElectronico)
                {
                    ListElectronico.Items.Add(libro);
                }
            }
        }

        private void cboTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cboTipoLibro.SelectedItem.ToString();

            if (seleccion == "Libro Físico")
            {
                ListFisico.Enabled = true;
                ListElectronico.Enabled = false;
                ListElectronico.ClearSelected(); // Desmarcar selección en la lista de electrónicos
            }
            else if (seleccion == "Libro Electrónico")
            {
                ListElectronico.Enabled = true;
                ListFisico.Enabled = false;
                ListFisico.ClearSelected(); // Desmarcar selección en la lista de físicos
            }
            else
            {
                ListFisico.Enabled = false;
                ListElectronico.Enabled = false;
                ListFisico.ClearSelected();
                ListElectronico.ClearSelected();
            }
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            Miembro miembroSeleccionado = cboNombreMiembro.SelectedItem as Miembro;
            Libro libroSeleccionado = ObtenerLibroSeleccionado();

            if (miembroSeleccionado == null || libroSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un miembro y un libro.");
                return;
            }

            Prestamo prestamo = new Prestamo(
                miembroSeleccionado,
                libroSeleccionado,
                dtpFechaSalida.Value,
                dtpFechaDevolucion.Value,
                libroSeleccionado is LibroElectronico);

            _dataManager.AgregarPrestamo(prestamo);
            ActualizarListaPrestamos();
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            Prestamo prestamoSeleccionado = lstPrestamos.SelectedItem as Prestamo;
            if (prestamoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un préstamo.");
                return;
            }

            _dataManager.EliminarPrestamo(prestamoSeleccionado);
            ActualizarListaPrestamos();
        }

        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            Prestamo prestamoSeleccionado = lstPrestamos.SelectedItem as Prestamo;
            if (prestamoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un préstamo.");
                return;
            }

            // Lógica para modificar el préstamo
        }

        private void ActualizarListaPrestamos()
        {
            lstPrestamos.Items.Clear();
            foreach (Prestamo prestamo in _dataManager.ObtenerPrestamos())
            {
                lstPrestamos.Items.Add(prestamo);
            }
        }

        private Libro ObtenerLibroSeleccionado()
        {
            if (ListFisico.Enabled && ListFisico.SelectedItem != null)
                return ListFisico.SelectedItem as Libro;

            if (ListElectronico.Enabled && ListElectronico.SelectedItem != null)
                return ListElectronico.SelectedItem as Libro;

            return null;
        }

        private void ListFisico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Desmarcar la lista de electrónicos si se selecciona un libro físico
            if (ListFisico.SelectedItem != null)
            {
                ListElectronico.ClearSelected();
            }
        }

        private void ListElectronico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Desmarcar la lista de físicos si se selecciona un libro electrónico
            if (ListElectronico.SelectedItem != null)
            {
                ListFisico.ClearSelected();
            }
        }

        private void lstPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizar campos basados en el préstamo seleccionado
            Prestamo prestamoSeleccionado = lstPrestamos.SelectedItem as Prestamo;
            if (prestamoSeleccionado != null)
            {
                cboNombreMiembro.SelectedItem = prestamoSeleccionado.Miembro;

                if (prestamoSeleccionado.Libro is LibroFisico libroFisico)
                {
                    cboTipoLibro.SelectedItem = "Libro Físico";
                    ListFisico.Enabled = true;
                    ListFisico.SelectedItem = libroFisico;
                    ListElectronico.ClearSelected(); // Desmarcar la lista de electrónicos
                }
                else if (prestamoSeleccionado.Libro is LibroElectronico libroElectronico)
                {
                    cboTipoLibro.SelectedItem = "Libro Electrónico";
                    ListElectronico.Enabled = true;
                    ListElectronico.SelectedItem = libroElectronico;
                    ListFisico.ClearSelected(); // Desmarcar la lista de físicos
                }

                dtpFechaSalida.Value = prestamoSeleccionado.FechaSalida;
                dtpFechaDevolucion.Value = prestamoSeleccionado.FechaDevolucion;
            }
        }
    }
}
