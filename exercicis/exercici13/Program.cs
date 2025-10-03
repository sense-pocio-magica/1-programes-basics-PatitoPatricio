namespace exercici13;

/* Un alumne ha inventat un sistema per codificar dates que consisteix a eliminar els separadors de les dates 
per fer no es vegi que són dates (la data 24/09/2024 la converteix en 24092024). 
El problema és que ho ha aplicat a tots els documents de l’institut i ara la direcció no sap 
ordenar els documents.

Necessitem un programa que faci el procés invers

Entra la data sense formatar: 25092024
La data és 25/09/2024

Entra la data sense formatar: 12031970
La data és 12/03/1970 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data");
        var data = Console.ReadLine();

        char d1 = data[0];
        char d2 = data[1];
        char d3 = data[2];
        char d4 = data[3];
        char d5 = data[4];
        char d6 = data[5];
        char d7 = data[6];
        char d8 = data[7];

        Console.WriteLine("La data és: "+d1+d2+"/"+d3+d4+"/"+d5+d6+d7+d8);
        
        //Aqui he declarat una variable per donar els numeros de la data pero no els he convertit a numeros els he declarat com string per determinar cada caracter i posar-lo a dins del Console.WriteLine i definir a on van les barres per donarli format a la data
        
        
        

    }
}
