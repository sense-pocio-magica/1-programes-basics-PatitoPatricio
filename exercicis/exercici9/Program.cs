namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Metres");
        var metres = Console.ReadLine();
        int peus = Convert.ToInt32(metres);
        Console.WriteLine("Metres a peus: "+peus*3,2808f);
    }
}       //He creat les variables per els metres i ho ha passat a numero per que es pugui fer la conversio de metres a peus
