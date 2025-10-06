namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("El teu nom és: ");
        var nom = Console.ReadLine();
        var nom1 = nom.Substring(0,1).ToUpper();
        var cognom = Console.ReadLine();
        var cognom2 = cognom.Substring(0, 1).ToUpper();
        string restadelnom = nom.Substring(1,nom.Length - 1);
        string restadelcognom = cognom.Substring(1, cognom.Length - 1);



        
        Console.WriteLine("El teu nom és: "+ nom1 + restadelnom+ " " + cognom2 + restadelcognom);
    }
}       //Aquí he definit variables per el nom i cognom pero he fet servir substrings per agafar diferents parts del nom i cognom i el que volia que fos en majuscules li he afegit un ToUpper i ho he ajuntat tot en un Console.Writeline
