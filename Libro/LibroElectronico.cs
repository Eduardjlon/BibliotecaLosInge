using System;

public class LibroElectronico : Libro
{
    public string Formato { get; set; }
    private string _tamañoPdf; // Propiedad privada para almacenar el tamaño de PDF

    public LibroElectronico(string titulo, string autor, int añoPublicacion, string formato)
        : base(titulo, autor, añoPublicacion, "Electrónico")
    {
        Formato = formato;
        _tamañoPdf = GenerarTamañoSiEsPdf(); // Generar el tamaño al crear el libro si es PDF
    }

    // Método para generar el tamaño si el formato es PDF
    private string GenerarTamañoSiEsPdf()
    {
        if (Formato == "PDF" && string.IsNullOrEmpty(_tamañoPdf))
        {
            Random random = new Random();
            int tamañoMB = random.Next(1, 1000); // Tamaño aleatorio entre 1 y 999 MB
            return $"{tamañoMB} MB";
        }
        return _tamañoPdf;
    }

    // Método público para obtener el tamaño del PDF (que ya se generó al crear el libro)
    public string ObtenerTamaño()
    {
        return _tamañoPdf;
    }

    public override string ToString()
    {
        return $"{Titulo} - {Autor} ({AñoPublicacion}) - Tipo: {Tipo} - Formato: {Formato}";
    }
}
