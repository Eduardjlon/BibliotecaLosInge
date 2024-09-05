public class LibroElectronico : Libro
{
    // Constructor que recibe todos los parámetros necesarios, incluyendo formato
    public LibroElectronico(string titulo, string autor, int añoPublicacion, string formato)
        : base(titulo, autor, añoPublicacion, "Electrónico") // Llama al constructor base de Libro con "Electrónico" como tipo
    {
        Formato = formato; // Inicializa la propiedad adicional Formato
    }

    // Constructor que solo recibe los parámetros básicos y asigna un formato por defecto
    public LibroElectronico(string titulo, string autor, int añoPublicacion)
        : base(titulo, autor, añoPublicacion, "Electrónico") // Llama al constructor base de Libro con "Electrónico" como tipo
    {
        Formato = "PDF"; // Asigna un formato por defecto si no se proporciona
    }

    public string Formato { get; set; }

    public override string ToString()
    {
        return $"{Titulo} - {Autor} ({AñoPublicacion}) - Tipo: {Tipo} - Formato: {Formato}";
    }
}
