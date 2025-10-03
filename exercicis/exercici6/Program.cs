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
        
    } //En aquest ejercici he creat la variable CM i l'he passat a nombre enter perque m'ho detecti com a numero i aixi poder-ho multiplicar perque em dongui el perimetre del cuadrat
}
