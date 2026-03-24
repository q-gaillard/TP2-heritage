class Archer : Personnage
{
    private int precision;

    public int GetPrecision()
    {
        return this.precision;
    }
    public void SetPrecision()
    {
        this.precision = precision;
        if (precision > 100)
        {
            presicion = 100;
            Console.WriteLine("| ! | la precision ne peut pas être au dessus de 100 %");
        }
    }

    public Archer(string nom, int pointDeVie, int precision) : base(nom, pointDeVie)
    {
        this.nom = nom;
        this.pointDeVie = pointDeVie;
        this.precision = precision;
    }
    public Archer() : base()
    {
        this.nom = "sans nom";
        this.pointDeVie = 0;
        this.precision = 0;
        if (precision > 100)
        {
            precision = 100;
            Console.WriteLine("| ! | la precision ne peut pas être au dessus de 100 %");
        }
    }

    public void Tirer()
    {
        Console.WriteLine($"{nom} tire avec une precision de {precision} %");
    }

    public override void Afficher()
    {
        Console.WriteLine("------ Information de l'archer ------");
        Console.WriteLine($"nom : {nom}");
        Console.WriteLine($"PV : {pointDeVie}");
        Console.WriteLine($"precision à l'arc : {precision} %");
        Console.WriteLine("---------------------------------------");
    }
}