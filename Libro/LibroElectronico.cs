public class LibroElectronico : Libro
{
    public LibroElectronico(string titulo, string autor, int añoPublicacion, string formato)
        : base(titulo, autor, añoPublicacion, "Electrónico") // Llama al constructor base de Libro
    {
        Formato = formato; // Inicializa la propiedad adicional Formato
    }

    public string Formato { get; set; }
}
