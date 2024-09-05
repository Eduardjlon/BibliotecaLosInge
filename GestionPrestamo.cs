using System;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaLosInge
{
    public partial class GestionPrestamo : Form
    {
        private DataManager _dataManager;
        private Miembro miembroSeleccionado;

        public GestionPrestamo()
        {
            InitializeComponent();
            _dataManager = DataManager.Instance; // Singleton
            CargarMiembros();
            CargarLibros();
            InicializarEstados();
            CargarTiposDeLibro();
        }

        private void CargarMiembros()
        {
            cboNombreMiembro.Items.Clear();
            foreach (var miembro in _dataManager.ObtenerMiembros())
            {
                cboNombreMiembro.Items.Add(miembro);
            }
        }

        private void CargarLibros()
        {
            ListFisico.Items.Clear();
            ListElectronico.Items.Clear();

            foreach (var libro in _dataManager.ObtenerLibros())
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

        private void InicializarEstados()
        {
            cboTipoLibro.SelectedIndex = -1; // Inicialmente, no se selecciona ningún tipo de libro
            ListFisico.Enabled = false; // Deshabilitar lista de libros físicos
            ListElectronico.Enabled = false; // Deshabilitar lista de libros electrónicos
            ListFisico.ClearSelected(); // Limpiar selección en lista de físicos
            ListElectronico.ClearSelected(); // Limpiar selección en lista de electrónicos
        }

        private void CargarTiposDeLibro()
        {
            cboTipoLibro.Items.Clear();
            cboTipoLibro.Items.Add("Libro Físico");
            cboTipoLibro.Items.Add("Libro Electrónico");
            cboTipoLibro.SelectedIndex = -1; // No seleccionar ningún ítem por defecto
        }

        private void cboTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = cboTipoLibro.SelectedItem?.ToString() ?? "";

            // Deshabilitar ambas listas antes de habilitar la correcta
            ListFisico.Enabled = false;
            ListElectronico.Enabled = false;

            // Limpiar selección en ambas listas
            ListFisico.ClearSelected();
            ListElectronico.ClearSelected();

            if (tipoSeleccionado == "Libro Físico")
            {
                ListFisico.Enabled = true; // Habilitar lista de libros físicos
            }
            else if (tipoSeleccionado == "Libro Electrónico")
            {
                ListElectronico.Enabled = true; // Habilitar lista de libros electrónicos
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

            // Cargar los datos del préstamo seleccionado en los controles
            cboNombreMiembro.SelectedItem = prestamoSeleccionado.Miembro;
            if (prestamoSeleccionado.Libro is LibroFisico)
            {
                cboTipoLibro.SelectedItem = "Libro Físico";
                ListFisico.SelectedItem = prestamoSeleccionado.Libro;
            }
            else
            {
                cboTipoLibro.SelectedItem = "Libro Electrónico";
                ListElectronico.SelectedItem = prestamoSeleccionado.Libro;
            }
            dtpFechaSalida.Value = prestamoSeleccionado.FechaSalida;
            dtpFechaDevolucion.Value = prestamoSeleccionado.FechaDevolucion;

            // Modificar el préstamo existente
            _dataManager.EliminarPrestamo(prestamoSeleccionado);
            btnAgregarPrestamo.Text = "Guardar Cambios";
            btnAgregarPrestamo.Click -= btnAgregarPrestamo_Click;
            btnAgregarPrestamo.Click += (s, args) =>
            {
                Prestamo prestamoModificado = new Prestamo(
                    miembroSeleccionado,
                    ObtenerLibroSeleccionado(),
                    dtpFechaSalida.Value,
                    dtpFechaDevolucion.Value,
                    ObtenerLibroSeleccionado() is LibroElectronico);

                _dataManager.AgregarPrestamo(prestamoModificado);
                ActualizarListaPrestamos();
                btnAgregarPrestamo.Text = "Agregar";
                btnAgregarPrestamo.Click -= (s, args) =>
                {
                    btnAgregarPrestamo_Click(s, args);
                };
                btnAgregarPrestamo.Click += btnAgregarPrestamo_Click;
            };
        }

        private void ActualizarListaPrestamos()
        {
            lstPrestamos.Items.Clear();
            foreach (var prestamo in _dataManager.ObtenerPrestamos())
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
    }
}
