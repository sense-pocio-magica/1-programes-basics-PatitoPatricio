namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("numero de minuts:");
        var Minuts = Console.ReadLine();
        int minuts = Convert.ToInt32(Minuts);


        int dies = minuts / (60 * 24);
        int hores = minuts % (60 * 24) /60;
        int minuts1 = minuts % 60;

        Console.WriteLine( dies+ " dies " + hores  + "hores" + " minuts " + minuts1);
    }
}
