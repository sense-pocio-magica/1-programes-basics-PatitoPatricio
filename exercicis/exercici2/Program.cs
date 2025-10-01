namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina és la teva adreça?");
        var carrer = Console.ReadLine();
        var numero = Console.ReadLine();
        var Cpostal = Console.ReadLine();
        var Poblacio = Console.ReadLine();
        Console.WriteLine("La teva adreça es: " + carrer +" "+ numero + " "+ Cpostal + " " + Poblacio);
    }
}
