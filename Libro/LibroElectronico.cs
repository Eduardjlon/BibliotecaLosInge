public class LibroElectronico : Libro
{
    public string URLDescarga { get; set; }

    public LibroElectronico(string titulo, string autor, int añoPublicacion, string urlDescarga)
        : base(titulo, autor, añoPublicacion)
    {
        URLDescarga = urlDescarga;
    }
}
