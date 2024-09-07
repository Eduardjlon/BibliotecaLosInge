using System;

public class LibroFisico : Libro
{
    public int Cantidad { get; set; }

    // Lista de estantes predefinidos
    private static readonly string[] estantes = { "P1A", "P2A", "P3A", "P1J", "P2J", "P3J", "P1D", "P2D", "P3D" };

    public LibroFisico(string titulo, string autor, int añoPublicacion, int cantidad = 1)
        : base(titulo, autor, añoPublicacion, "Físico") // Pasa "Físico" como tipo
    {
        Cantidad = cantidad;
    }

    // Método para generar la ubicación aleatoria cuando sea necesario
    public string GenerarUbicacionAleatoria()
    {
        Random random = new Random();
        return estantes[random.Next(estantes.Length)];
    }

    public override string ToString()
    {
        return $"{Titulo} ({Cantidad})";
    }
}
