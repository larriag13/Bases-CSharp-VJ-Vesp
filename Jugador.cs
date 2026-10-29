public class Jugador
{
    public string Name { get; set; }
    public int Edad { get; set; }

    public Jugador()
    {
        Name = "";
        Edad = 0;
    }
    public Jugador(string name, int edad)
    {
        Name = name;
        Edad = edad;
    }

    public override string ToString()
    {
        return $"Nombre: {Name}, Edad: {Edad}";
    }
}