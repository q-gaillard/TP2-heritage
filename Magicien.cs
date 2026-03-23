class Guerrier : Personnage
{
    private int puissanceMagique;

    public int GetPuissanceMagique()
    {
        return this.puissanceMagique;
    }
    public void SetPuissanceMagique()
    {
        this.puissanceMagique = puissanceMagique;
    }

    public Guerrier(string nom, int pointDeVie, int puissanceMagique) : base(nom, pointDeVie)
    {
        this.nom = nom;
        this.pointDeVie = pointDeVie;
        this.puissanceMagique = puissanceMagique;
    }
    public Guerrier() : base()
    {
        this.nom = "sans nom";
        this.pointDeVie = 0;
        this.puissanceMagique = 0;
    }

    public new void Afficher()
    {
        Console.WriteLine("------ Information du magicien ------");
        Console.WriteLine($"nom : {nom}");
        Console.WriteLine($"PV : {pointDeVie}");
        Console.WriteLine($"puissance magique : {puissanceMagique}");
        Console.WriteLine("---------------------------------------");
    }
}