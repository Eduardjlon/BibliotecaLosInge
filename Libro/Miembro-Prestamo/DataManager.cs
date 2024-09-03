namespace BibliotecaLosInge
{
    public class DataManager
    {
        private static DataManager instance;
        private List<Libro> libros;
        private List<Miembro> miembros;
        private List<Prestamo> prestamos;

        private DataManager()
        {
            libros = new List<Libro>();
            miembros = new List<Miembro>();
            prestamos = new List<Prestamo>();
        }

        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataManager();
                }
                return instance;
            }
        }

        public List<Libro> ObtenerLibros()
        {
            return libros;
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void EliminarLibro(Libro libro)
        {
            libros.Remove(libro);
        }

        public List<Miembro> ObtenerMiembros()
        {
            return miembros;
        }

        public void AgregarMiembro(Miembro miembro)
        {
            miembros.Add(miembro);
        }

        public void EliminarMiembro(Miembro miembro)
        {
            miembros.Remove(miembro);
        }

        public List<Prestamo> ObtenerPrestamos()
        {
            return prestamos;
        }

        public void AgregarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }

        public void EliminarPrestamo(Prestamo prestamo)
        {
            prestamos.Remove(prestamo);
        }
    }
}
