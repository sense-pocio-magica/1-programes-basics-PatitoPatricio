namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Numeros:");
        var Mitjana1 = Console.ReadLine();
        double mitjana1 = Convert.ToDouble(Mitjana1);
        var Mitjana2 = Console.ReadLine();
        double mitjana2 = Convert.ToDouble(Mitjana2);
        var Mitjana3 = Console.ReadLine();
        double mitjana3 = Convert.ToDouble(Mitjana3);
        Console.WriteLine("Numeros: "+ (mitjana1 + mitjana2 + mitjana3) / 3);
    }
}       //En aquest exercici he creat les variables per cada nota i cadaescuna les he passat a numeros fent servir el double perque em dongui numeros amb decimals, llavors he fet la mitjana al Console.WriteLine
