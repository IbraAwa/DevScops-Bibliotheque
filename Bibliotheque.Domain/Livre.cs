namespace Bibliotheque.Domain;

public class Livre
{
    public Livre(string titre, decimal? prix, int nombrePage, DateTime? parution)
    {
        Titre = titre;
        Prix = prix;
        NombrePage = nombrePage;
        Parution = parution;
    }

    // nom de propriété en majuscule le premier mot
    // PascalCase
    public string Titre { get; set; }

    public decimal? Prix { get; set; }

    public int NombrePage { get; set; }

    public DateTime? Parution { get; set; }
}
