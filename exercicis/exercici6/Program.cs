namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Costats en CM");
        var CM1 = Console.ReadLine();
        int cm1 = Convert.ToInt32(CM1);
        Console.WriteLine("El perimetre és "+ cm1 * 4+ " cm");
        
    }
}
