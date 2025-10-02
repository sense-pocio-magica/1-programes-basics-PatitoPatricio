namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        string missatge = "Carroña";
        char primeralletra = missatge[0];
        char lletradelmitg = missatge[6];
        char lletradelfinal = missatge[3];

        Console.WriteLine("primera LLetra: "+ primeralletra+ " lletra del final: " + lletradelfinal + " lletra del mitg: " + lletradelmitg);
    }
}
