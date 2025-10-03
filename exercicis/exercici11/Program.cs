namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("El teu nom");
        var nom = Console.ReadLine();
        Console.WriteLine("El teu domini");
        var domini = Console.ReadLine();
        Console.WriteLine("El teu domini "+nom+"@"+domini);
    }
}       //En aquest cas he posat dos variables per juntarles i crear el domini
