using System;

public class LibroFisico : Libro
{
    public int Cantidad { get; set; }
    public string Ubicacion { get; private set; }

    public LibroFisico(string titulo, string autor, int añoPublicacion, int cantidad = 1)
        : base(titulo, autor, añoPublicacion, "Físico") // Pasa "Físico" como tipo
    {
        Cantidad = cantidad;
        Ubicacion = GenerarUbicacionAleatoria(); // Asigna una ubicación aleatoria al crear el libro
    }

    private string GenerarUbicacionAleatoria()
    {
        Random random = new Random();
        char letra = (char)('A' + random.Next(0, 26)); // Genera una letra aleatoria entre A y Z
        return letra.ToString();
    }

    public override string ToString()
    {
        return $"{Titulo} ({Cantidad}) - Ubicación: {Ubicacion}";
    }
}
