class Guerrier : Personnage
{
    private int armure;

    public int GetArmure()
    {
        return this.armure;
    }
    public void SetArmure()
    {
        this.armure = armure;
    }

    public Guerrier(string nom, int pointDeVie, int armure) : base(nom, pointDeVie)
    {
        this.nom = nom;
        this.pointDeVie = pointDeVie;
        this.armure = armure;
    }
    public Guerrier() : base()
    {
        this.nom = "sans nom";
        this.pointDeVie = 0;
        this.armure = 0;
    }

    public override void RecevoirDegats(int degat)
    {
        if (degat - armure > pointDeVie)
        {
            pointDeVie = 0;
        }
        else
        {
            if (degat - armure < 0)
            {
                degat = 0;
            }
            else
            {
                pointDeVie = pointDeVie - (degat - armure);
            }
        }
    }

    public override void RecevoirDegats(int degat, int reduction)
    {
        if (degat - armure - reduction > pointDeVie)
        {
            pointDeVie = 0;
        }
        else
        {
            if (degat - armure - reduction < 0)
            {
                degat = 0;
            }
            else
            {
                pointDeVie = pointDeVie - (degat - armure - reduction);
            }
        }
    }

    public void Attaquer()
    {
        Console.WriteLine($"{nom} attaque !");
    }

    public override void Afficher()
    {
        Console.WriteLine("------ Information du guerrier ------");
        Console.WriteLine($"nom : {nom}");
        Console.WriteLine($"PV : {pointDeVie}");
        Console.WriteLine($"armure : {armure}");
        Console.WriteLine("---------------------------------------");
    }
}