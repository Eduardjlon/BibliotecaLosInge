namespace BibliotecaLosInge
{
    public class Miembro
    {
        public string Nombre { get; set; }
        public string NumeroMiembro { get; set; }

        public Miembro(string nombre, string numeroMiembro)
        {
            Nombre = nombre;
            NumeroMiembro = numeroMiembro;
        }

        public override string ToString()
        {
            return $"{Nombre} - {NumeroMiembro}";
        }
    }
}
