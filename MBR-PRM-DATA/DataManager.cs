using System.Collections.Generic;

namespace BibliotecaLosInge
{
    public class DataManager
    {
        private static DataManager instance;
        private List<Libro> libros;
        private List<Miembro> miembros;
        private List<Prestamo> prestamos;
        private Dictionary<(string Titulo, string Autor, int AñoPublicacion), int> librosFisicos;

        private DataManager()
        {
            libros = new List<Libro>();
            miembros = new List<Miembro>();
            prestamos = new List<Prestamo>();
            librosFisicos = new Dictionary<(string, string, int), int>();
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
            if (libro is LibroFisico libroFisico)
            {
                (string Titulo, string Autor, int AñoPublicacion) clave = (libroFisico.Titulo, libroFisico.Autor, libroFisico.AñoPublicacion);
                if (librosFisicos.ContainsKey(clave))
                {
                    // Si el libro ya existe, actualizamos la cantidad
                    librosFisicos[clave]++;
                    // Actualizamos la lista de libros para reflejar la nueva cantidad
                    ActualizarListaLibros();
                }
                else
                {
                    // Si el libro no existe, lo agregamos con cantidad 1
                    librosFisicos[clave] = 1;
                    libros.Add(libroFisico);
                }
            }
            else
            {
                // Para libros electrónicos, simplemente agregamos
                libros.Add(libro);
            }
        }

        public void EliminarLibro(Libro libro)
        {
            if (libro is LibroFisico libroFisico)
            {
                (string Titulo, string Autor, int AñoPublicacion) clave = (libroFisico.Titulo, libroFisico.Autor, libroFisico.AñoPublicacion);
                if (librosFisicos.ContainsKey(clave))
                {
                    // Disminuimos la cantidad o eliminamos si es 1
                    if (librosFisicos[clave] > 1)
                    {
                        librosFisicos[clave]--;
                    }
                    else
                    {
                        librosFisicos.Remove(clave);
                        libros.Remove(libroFisico);
                    }
                }
            }
            else
            {
                libros.Remove(libro);
            }
        }

        public void ActualizarListaLibros() // Cambiado a public
        {
            libros.Clear();
            foreach (KeyValuePair<(string Titulo, string Autor, int AñoPublicacion), int> kvp in librosFisicos)
            {
                string titulo = kvp.Key.Titulo;
                string autor = kvp.Key.Autor;
                int añoPublicacion = kvp.Key.AñoPublicacion;
                int cantidad = kvp.Value;

                // Creamos una instancia de LibroFisico con cantidad indicada
                LibroFisico libro = new LibroFisico(titulo, autor, añoPublicacion); // Aquí solo necesitamos los argumentos básicos
                libros.Add(libro);
            }
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
        public void ModificarPrestamo(Prestamo prestamo)
        {
            // Encuentra el índice del préstamo a modificar
            int index = prestamos.IndexOf(prestamo);
            if (index >= 0)
            {
                prestamos[index] = prestamo; // Actualiza el préstamo en la lista
            }
        }
    }
}
