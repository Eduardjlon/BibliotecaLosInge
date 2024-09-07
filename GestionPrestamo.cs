using System;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaLosInge
{
    public partial class GestionPrestamo : Form
    {
        private DataManager _dataManager;
        private Prestamo _prestamoEnEdicion;

        public GestionPrestamo()
        {
            InitializeComponent();
            _dataManager = DataManager.Instance;
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
                if (libro is LibroFisico libroFisico)
                {
                    ListFisico.Items.Add(libroFisico);
                }
                else if (libro is LibroElectronico libroElectronico)
                {
                    ListElectronico.Items.Add(libroElectronico);
                }
            }
        }

        private void InicializarEstados()
        {
            cboTipoLibro.SelectedIndex = -1;
            ListFisico.Enabled = false;
            ListElectronico.Enabled = false;
            ListFisico.ClearSelected();
            ListElectronico.ClearSelected();
            btnAgregarPrestamo.Text = "Agregar";
            _prestamoEnEdicion = null;
        }

        private void CargarTiposDeLibro()
        {
            cboTipoLibro.Items.Clear();
            cboTipoLibro.Items.Add("Libro Físico");
            cboTipoLibro.Items.Add("Libro Electrónico");
            cboTipoLibro.SelectedIndex = -1;
        }

        private void cboTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = cboTipoLibro.SelectedItem?.ToString() ?? "";

            ListFisico.Enabled = tipoSeleccionado == "Libro Físico";
            ListElectronico.Enabled = tipoSeleccionado == "Libro Electrónico";

            ListFisico.ClearSelected();
            ListElectronico.ClearSelected();
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

            if (_prestamoEnEdicion == null)
            {
                Prestamo prestamo = new Prestamo(
                    miembroSeleccionado,
                    libroSeleccionado,
                    dtpFechaSalida.Value,
                    dtpFechaDevolucion.Value,
                    libroSeleccionado is LibroElectronico);

                _dataManager.AgregarPrestamo(prestamo);

                if (libroSeleccionado is LibroFisico libroFisico)
                {
                    if (libroFisico.Cantidad > 0)
                    {
                        libroFisico.Cantidad--;
                        _dataManager.ActualizarListaLibros();
                    }
                    else
                    {
                        MessageBox.Show("No hay suficientes copias del libro físico para realizar el préstamo.");
                        return;
                    }
                }
            }
            else
            {
                Prestamo prestamoModificado = new Prestamo(
                    miembroSeleccionado,
                    libroSeleccionado,
                    dtpFechaSalida.Value,
                    dtpFechaDevolucion.Value,
                    libroSeleccionado is LibroElectronico);

                _dataManager.EliminarPrestamo(_prestamoEnEdicion);
                _dataManager.AgregarPrestamo(prestamoModificado);
                _prestamoEnEdicion = null;
                btnAgregarPrestamo.Text = "Agregar";
            }

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

            if (prestamoSeleccionado.Libro is LibroFisico libroFisico)
            {
                libroFisico.Cantidad++;
                _dataManager.ActualizarListaLibros();
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

            cboNombreMiembro.SelectedItem = prestamoSeleccionado.Miembro;
            if (prestamoSeleccionado.Libro is LibroFisico libroFisico)
            {
                cboTipoLibro.SelectedItem = "Libro Físico";
                ListFisico.SelectedItem = libroFisico;
            }
            else
            {
                cboTipoLibro.SelectedItem = "Libro Electrónico";
                ListElectronico.SelectedItem = prestamoSeleccionado.Libro;
            }
            dtpFechaSalida.Value = prestamoSeleccionado.FechaSalida;
            dtpFechaDevolucion.Value = prestamoSeleccionado.FechaDevolucion;

            _prestamoEnEdicion = prestamoSeleccionado;
            btnAgregarPrestamo.Text = "Modificar";
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
            if (cboTipoLibro.SelectedItem?.ToString() == "Libro Físico")
            {
                return ListFisico.SelectedItem as Libro;
            }
            else if (cboTipoLibro.SelectedItem?.ToString() == "Libro Electrónico")
            {
                return ListElectronico.SelectedItem as Libro;
            }
            return null;
        }
    }
}
//A dormir