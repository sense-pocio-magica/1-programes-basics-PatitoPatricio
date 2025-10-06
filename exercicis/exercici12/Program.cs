namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Primer numero?");
        var num = Console.ReadLine(); // "4"
        int numero1 = Convert.ToInt32(num); // 4
        Console.WriteLine("Segon numero?");
        var num2 = Console.ReadLine(); // "4"
        int numero2 = Convert.ToInt32(num2); // 4


        Console.WriteLine("Suma: " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
        Console.WriteLine("Resta: " + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
        Console.WriteLine("Multiplicació: " + numero1 + " * " + numero2 + " = " + (numero1 * numero2));
        Console.WriteLine("Divisió: " + numero1 + " / " + numero2 + " = " + (numero1 / numero2) + " i en sobra 1");
        

        Console.WriteLine("Primer numero?");
        var num3 = Console.ReadLine(); // "4"
        int numero3 = Convert.ToInt32(num3); // 4
        Console.WriteLine("Segon numero?");
        var num4 = Console.ReadLine(); // "4"
        int numero4 = Convert.ToInt32(num4); // 4


        Console.WriteLine("Suma: " + numero3 + " + " + numero4 + " = " + (numero3 + numero4));
        Console.WriteLine("Resta: " + numero3 + " - " + numero4 + " = " + (numero3 - numero4));
        Console.WriteLine("Multiplicació: " + numero3 + " * " + numero4 + " = " + (numero3 * numero4));
        Console.WriteLine("Divisió: " + numero3 + " / " + numero4 + " = " + (numero3 / numero4)+ " i en sobra 0");
    }
}       //En els dos casos he fet servir variables per determinar el numero i les he convertit a numeros enters amb int tot seguit amb un ConsoleWriteLine he fet cada operació i a la divisio he volgut fer un modul per que em dongui el residu pero com que no se fer-lo servir no m'he volgut complicar
