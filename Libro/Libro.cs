public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AñoPublicacion { get; set; }
    public string Tipo { get; set; }  // Propiedad para el tipo de libro

    // Constructor que recibe todos los parámetros necesarios
    public Libro(string titulo, string autor, int añoPublicacion, string tipo)
    {
        Titulo = titulo;
        Autor = autor;
        AñoPublicacion = añoPublicacion;
        Tipo = tipo;  // Asigna el tipo del libro
    }

    // Método para representar el libro en forma de cadena
    public override string ToString()
    {
        return $"{Titulo} - {Autor} ({AñoPublicacion}) - Tipo: {Tipo}";  // Muestra el tipo en la cadena
    }
}
