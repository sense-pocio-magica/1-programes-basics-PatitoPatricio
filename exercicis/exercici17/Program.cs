namespace exercici17;

/* Hi ha una secta d’adoradors dels decimals que volen que els hi feu un programa que a partir d’un nombre real, 
ex. 4.56, només ens retorni els decimals, 0,56. Als números que només tenen decimals els anomenen “nombres meravellosos”

Número lleig: 23,45
Nombre meravellós: 0,45


Número lleig: 8,5
Nombre meravellós: 0,5
*/

class Program
{
    static void Main(string[] args)
    {
        string num = "23.45";
        string nomeselnum = num.Substring(2);

        Console.WriteLine("el numero és; " + "0" + nomeselnum);
        
        string num1 = "8,5";
        string nomeselnum1 = num1.Substring(1);

        Console.WriteLine("el numero és; "+"0"+ nomeselnum1);


    }   //Aqui he fet servir l'us del substring per que nomes m'agafi la part amb decimals i li he posat un 0 devant 
}
