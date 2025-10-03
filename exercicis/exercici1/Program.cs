namespace exercici1;

/* Escriviu un programa que demani el nom i el cognom de l’usuari i que el presenti com en James Bond

Entra el nom: Pere
Entra el cognom: González

Em dic González, Pere González

Entra el nom: Joan
Entra el cognom: Pi

Em dic Pi, Joan Pi 

*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Com et dius?"); //Aixó el que fa, és escriure a la terminal un nombre de caracters, en aquest cas, com et dius
        var nom = Console.ReadLine(); //Aixó determina una variable que en aquest cas serà la del nom i et permet escriure la variable
        var cognom = Console.ReadLine(); //Aixó es el mateix que l'altre variable pero canviant el nom de la variable de nom ----> cognom
        Console.WriteLine("El teu nom és " + nom +" " + cognom); //Aixó el que fa és escriure a la terminal "el teu nom és" i ajunta les dos variables que hem escrit anteriorment per formar una frase

    }
}
