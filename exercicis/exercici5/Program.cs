namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin nom i edat tens?"); 
        var nom = Console.ReadLine();
        var Edat = Console.ReadLine();
        int edat = Convert.ToInt32(Edat);
        Console.WriteLine("hola "+ nom +"! "+ "ja tens "+ Edat+ " anys?");
    }   //En aquest exercici he creat les variables que em demanava el exercici i amb un Console.Writeline ho he ajuntat mes
}
