public class LibroFisico : Libro
{
    public int Cantidad { get; set; }

    public LibroFisico(string titulo, string autor, int añoPublicacion, int cantidad = 1)
        : base(titulo, autor, añoPublicacion, "Físico") // Pasa "Físico" como tipo
    {
        Cantidad = cantidad;
    }

    public override string ToString()
    {
        return $"{Titulo} ({Cantidad})";
    }
}
