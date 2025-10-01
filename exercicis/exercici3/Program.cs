namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("quin producte vols?");
        string NomProducte = "Caca";
        int preu = 10;
        bool estoc = false;

        Controle.WriteLine("El meu producte anomenat" + " " + NomProducte + " " + "te un preu de " + preu);

        if (estoc == true)
        {
            Console.WriteLine("Si");

        }

        else {

            Console.WriteLine("no");
        }
    }
}
