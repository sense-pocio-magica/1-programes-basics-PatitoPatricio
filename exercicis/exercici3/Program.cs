namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("quin producte vols?"); //Aixó escriu a la terminal "quin producte vols
        string NomProducte = "Caca"; //Aixó declara el nom de un producte en aquest cas "caca"
        int preu = 10; //Aixó declara el preu
        bool estoc = false; // Aixó declara l'estat del estoc del producte

        Controle.WriteLine("El meu producte anomenat" + " " + NomProducte + " " + "te un preu de " + preu); //Aixó ajunta en una frase el que hem delcarat a les variables abans escrites

        if (estoc == true)   //Aquest if i else escolleix segons lo establert al costat del if, en aquest cas si el estoc esta en true escriura a la terminal que si que hi ha, pero si es false escriurea a la terminal que no hi ha
        {
            Console.WriteLine("Si");

        }

        else {

            Console.WriteLine("no");
        }
    }
}
