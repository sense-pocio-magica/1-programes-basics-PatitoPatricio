namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina és la teva adreça?"); //Aixó fa que escrigui a la terminal una sequencia de caracaters
        var carrer = Console.ReadLine(); //Aixó declara una variable
        var numero = Console.ReadLine(); //Aixó declara una variable
        var Cpostal = Console.ReadLine(); //Aixó declara una variable
        var Poblacio = Console.ReadLine(); //Aixó declara una variable
        Console.WriteLine("La teva adreça es: " + carrer + " " + numero + " " + Cpostal + " " + Poblacio); //Aixó escriu a la terminal una frase i ajunta totes les variables declarades anteriorment amb l'us del caracter "+"
    }
}
