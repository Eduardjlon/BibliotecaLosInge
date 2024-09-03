public class LibroFisico : Libro
{
    public string Ubicacion { get; set; }

    public LibroFisico(string titulo, string autor, int añoPublicacion, string ubicacion)
        : base(titulo, autor, añoPublicacion)
    {
        Ubicacion = ubicacion;
    }
}
