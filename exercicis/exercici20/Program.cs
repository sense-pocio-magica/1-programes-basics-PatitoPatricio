namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Numero que vols:");
        var num = Console.ReadLine();
        string d1 = num.Substring(0, 1);
        string d2 = num.Substring(1,1);
        string d3 = num.Substring(2);
        Console.WriteLine("El numero al reves: "+(d3)+ (d2) +(d1));
    }
}       //Aqui he fet que amb substrings agafi cada numero que posi a la variable i amb un Console.WriteLine els he posat del reves
