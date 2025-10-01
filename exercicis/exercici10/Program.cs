namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("El Teu Nom");
        var nom = Console.ReadLine();
        Console.WriteLine("El Teu Any de Neixament");
        var Any_neixament = Console.ReadLine();
        int any_neixament = Convert.ToInt32(Any_neixament);
        Console.WriteLine("La teva contrassenya és: "+nom+any_neixament);

    }
}
