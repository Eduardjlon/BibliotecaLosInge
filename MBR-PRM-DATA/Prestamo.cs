namespace BibliotecaLosInge
{
    public class Prestamo
    {
        public Miembro Miembro { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool EsElectronico { get; set; }

        public Prestamo(Miembro miembro, Libro libro, DateTime fechaSalida, DateTime fechaDevolucion, bool esElectronico)
        {
            Miembro = miembro;
            Libro = libro;
            FechaSalida = fechaSalida;
            FechaDevolucion = fechaDevolucion;
            EsElectronico = esElectronico;
        }

        public override string ToString()
        {
            var tipoLibro = EsElectronico ? "Libro electrónico" : "Libro físico";
            string mensajeAdicional = string.Empty;

            if (EsElectronico && Libro is LibroElectronico libroElectronico)
            {
                if (libroElectronico.Formato == "PDF")
                {
                    // Obtener tamaño aleatorio en MB para el archivo PDF
                    string tamañoPdf = libroElectronico.ObtenerTamaño();
                    // Mensaje para libro PDF
                    return $"{Miembro.Nombre} ha recibido el archivo PDF del libro '{Libro.Titulo}' el {FechaSalida.ToShortDateString()}, tamaño: {tamañoPdf}, con fecha de devolución: {FechaDevolucion.ToShortDateString()}.";
                }
                else if (libroElectronico.Formato == "URL")
                {
                    // Mostrar solo fecha de entrega y el link de acceso para libros en formato URL
                    return $"{Miembro.Nombre} se le brindó un link de acceso al libro '{Libro.Titulo}' el {FechaSalida.ToShortDateString()}.";
                }
            }
            else if (!EsElectronico && Libro is LibroFisico libroFisico)
            {
                // Generar una ubicación aleatoria para cada préstamo del libro físico
                string ubicacion = libroFisico.GenerarUbicacionAleatoria();
                mensajeAdicional = $"Tomó el libro del estante '{ubicacion}'.";
            }

            return $"{Miembro.Nombre} ha tomado prestado '{Libro.Titulo}' del autor '{Libro.Autor}' el {FechaSalida.ToShortDateString()}. " +
                   $"{mensajeAdicional} Fecha de devolución: {FechaDevolucion.ToShortDateString()}";
        }
    }
}
