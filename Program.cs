using System;

class Program
{
    static void Main(string[] args)
    {
        //création d'un personnage
        Personnage perso1 = new Personnage("shrek", 122);

        //intéraction avec shrek
        perso1.Afficher();
        Console.WriteLine("");
        perso1.RecevoirDegat(20);
        perso1.Afficher();

        //crée des personnages spéciaux
        Guerrier perso2 = new Guerrier("Alex de guerrier malicieux", 100, 20);
        Magicien perso3 = new Magicien("Harry Potter", 50, 30);

        //intéraction avec Alex et Harry Potter
        Console.WriteLine("");
        perso2.Affiche();
        Console.WriteLine("");
        perso3.Afficher();
        perso2.RecevoirDegat(30);
        Console.WriteLine("");
        perso2.Affiche();
    }  
}
