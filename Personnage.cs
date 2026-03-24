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

    public override string ToString()
    {
        return $"{nom} | PV: {pointDeVie}";
    }

    public virtual void RecevoirDegats(int degat)
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

    public virtual void RecevoirDegats(int degat, int reduction)
    {
        if (degat-reduction > pointDeVie)
        {
            pointDeVie = 0;
        }
        else
        {
            if (degat - reduction < 0)
            {
                degat = 0;
            }
            else
            {
                pointDeVie = pointDeVie - (degat - reduction);
            }
        }
    }

    public bool EstMort()
    {
        return (pointDeVie < 1);
    }

    public virtual void Afficher()
    {
        Console.WriteLine("------ Information du personnage ------");
        Console.WriteLine($"nom : {nom}");
        Console.WriteLine($"PV : {pointDeVie}");
        Console.WriteLine("---------------------------------------");
    }
}