using System.ComponentModel.DataAnnotations.Schema;

class Personnage
{
    protected string nom;
    protected int pointDeVie;

    public string GetNom()
    {
        return this.nom;
    }
    public void SetNom(string nom)
    {
        this.nom = nom;
    }

    public int GetPointDeVie()
    {
        return this.pointDeVie;
    }
    public void SetPointDeVie(int poitDeVie)
    {
        this.pointDeVie = pointDeVie;
    }

    public Personnage(string nom, int pointDeVie)
    {
        this.nom = nom;
        this.pointDeVie = pointDeVie;
    }
    public Personnage()
    {
        this.nom = "sans nom";
        this.pointDeVie = 0;
    }

    public void RecevoirDegat(int degat)
    {
        if (degat > pointDeVie)
        {
            pointDeVie = 0;
        }
        else
        {
            pointDeVie = pointDeVie - degat;
        }
    }

    public void Afficher()
    {
        Console.WriteLine("------ Information du personnage ------");
        Console.WriteLine($"nom : {nom}");
        Console.WriteLine($"PV : {pointDeVie}");
        Console.WriteLine("---------------------------------------");
    }
}