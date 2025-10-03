namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("La teva nota de practiques:");
        var notapractiques = Console.ReadLine();
        int nota1 = Convert.ToInt32(notapractiques);
        Console.WriteLine("La teva nota de Examen:");
        var notaexamen = Console.ReadLine();
        int nota2 = Convert.ToInt32(notaexamen);
        double resultat = nota1 * 0.3 + nota2 * 0.7;
        double resultat2 = Math.Truncate(resultat);
        Console.WriteLine("La teva nota final és: " + (nota1 * 0.3 + nota2 * 0.7) + " o sigui " + resultat2);
        
        Console.WriteLine("La teva nota de practiques:");
        var notapractiques2 = Console.ReadLine();
        int nota3 = Convert.ToInt32(notapractiques2);
        Console.WriteLine("La teva nota de Examen:");
        var notaexamen2 = Console.ReadLine();
        int nota4 = Convert.ToInt32(notaexamen2);
        double resultat3 = nota3 * 0.3 + nota4 * 0.7;
        double resultat4 = Math.Truncate(resultat3);
        Console.WriteLine("La teva nota final és: " + (nota3 * 0.3 + nota4 * 0.7) + " o sigui "+ resultat4);
        

    }       //Aqui he definit variables per fer servir els numeros per les operacions, pero tambe he fet servir el double per donar un resultat amb decimals i he estat investigant per veure com truncar els numeros i nomes he sapigut fer servir el Math.Truncate i bueno ho he ajuntat tot a dins de un Console.Writeline i al final he posat la variable resultat perque aixi no hagis te posar tu una lletra que ho faci automatic
}
