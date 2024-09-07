using System;

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

    public override string ToString()
    {
        if (Formato == "PDF")
        {
            Random rnd = new Random();
            int tamañoMB = rnd.Next(1, 1000); // Genera un tamaño aleatorio entre 1 y 999 MB
            return $"{Titulo} - {Autor} ({AñoPublicacion}) - Tipo: {Tipo} - Formato: {Formato} - Tamaño: {tamañoMB} MB";
        }
        return $"{Titulo} - {Autor} ({AñoPublicacion}) - Tipo: {Tipo} - Formato: {Formato}";
    }
}
