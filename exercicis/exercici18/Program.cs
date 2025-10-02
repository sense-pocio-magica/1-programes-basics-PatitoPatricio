namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hora actual: ");
        var hora = Console.ReadLine();
        int hora1 = Convert.ToInt32(hora);
        Console.WriteLine("hora a afegir: ");
        var horaaf = Console.ReadLine();
        int horaaf1 = Convert.ToInt32(horaaf);

        if ((hora1 + horaaf1) > 12)
        {
            Console.WriteLine("la hora és: " + ((hora1 + horaaf1)-12));
        }
        else
        {
            Console.WriteLine("la hora és: " + (hora1 + horaaf1));
        }
        
    }
}
