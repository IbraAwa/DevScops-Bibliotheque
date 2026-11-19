namespace Bibliotheque.Domain;

public class Manga
{
    public Manga(string titre, string genre, decimal prix)
    {
        Titre = titre;
        Genre = genre;
        Prix = prix;
    }

    public string Titre { get; set; }

    public string Genre { get; set;  }

    public decimal Prix { get; set; }
}