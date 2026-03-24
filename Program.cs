using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        //création d'un personnage
        Personnage perso1 = new Personnage("Shrek", 122);

        //intéraction avec shrek
        Console.WriteLine("personnage classique :");
        Console.WriteLine("");
        perso1.Afficher();
        Console.WriteLine("");
        perso1.RecevoirDegats(20);
        perso1.Afficher();

        //crée des personnages spéciaux
        Guerrier perso2 = new Guerrier("Alex de guerrier malicieux", 100, 20);
        Magicien perso3 = new Magicien("Harry Potter", 50, 30);

        //intéraction avec Alex et Harry Potter
        Console.WriteLine("personnage guerrier et mage :");
        Console.WriteLine("");
        perso2.Afficher();
        Console.WriteLine("");
        perso3.Afficher();
        perso2.RecevoirDegats(30);
        Console.WriteLine("");
        perso2.Afficher();

        //test virtuel et override
        Guerrier perso4 = new Guerrier("Arthur", 100, 20);
        Magicien perso5 = new Magicien("Merlin", 80, 50);
        Console.WriteLine("test virtual et overrride :");
        Console.WriteLine("");
        perso4.Afficher();
        perso5.Afficher();
    }  
}
