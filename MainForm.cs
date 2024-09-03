using System;
using System.Windows.Forms;

namespace BibliotecaLosInge
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGestionLibro_Click(object sender, EventArgs e)
        {
            GestionLibro gestionLibroForm = new GestionLibro();
            gestionLibroForm.ShowDialog();
        }

        private void btnGestionMiembro_Click(object sender, EventArgs e)
        {
            GestionMiembro gestionMiembroForm = new GestionMiembro();
            gestionMiembroForm.ShowDialog();
        }

        private void btnGestionPrestamo_Click(object sender, EventArgs e)
        {
            GestionPrestamo gestionPrestamoForm = new GestionPrestamo();
            gestionPrestamoForm.ShowDialog();
        }
    }
}
