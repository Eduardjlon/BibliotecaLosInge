using System;

namespace BibliotecaLosInge
{
    public class LibroElectronico : Libro
    {
        public LibroElectronico(string titulo, string autor, int añoPublicacion, string formato)
            : base(titulo, autor, añoPublicacion, "Electrónico")
        {
            Formato = formato;
        }

        public LibroElectronico(string titulo, string autor, int añoPublicacion)
            : base(titulo, autor, añoPublicacion, "Electrónico")
        {
            Formato = "PDF";
        }

        public string Formato { get; set; }

        public string ObtenerTamaño()
        {
            if (Formato == "PDF")
            {
                var random = new Random();
                int tamañoMb = random.Next(1, 1000); // Genera un número aleatorio entre 1 y 999
                return $"Tamaño: {tamañoMb} MB";
            }
            return "";
        }

        public override string ToString()
        {
            var tamaño = ObtenerTamaño();
            return $"{Titulo} - {Autor} ({AñoPublicacion}) - Tipo: {Tipo} - Formato: {Formato} {tamaño}";
        }
    }
}
