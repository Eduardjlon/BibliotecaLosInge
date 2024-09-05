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
            return $"{Miembro.Nombre} ha tomado prestado '{Libro.Titulo}' del autor '{Libro.Autor}' el {FechaSalida.ToShortDateString()}. " +
                   $"Tipo: {(EsElectronico ? "Libro electrónico" : "Libro físico")}. Fecha de devolución: {FechaDevolucion.ToShortDateString()}";
        }
    }
}
