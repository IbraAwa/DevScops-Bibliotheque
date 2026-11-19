using Bibliotheque.Domain;

namespace Bibliotheque.Infrastructure;

public static class LivresData
{
    public static List<Livre> Livres { get; set; } = new List<Livre>
    {
        // Toujours indenter
        new Livre(
            titre: "Le Petit Prince",
            prix: 8.50m,
            nombrePage: 96,
            parution: new DateTime(1943, 4, 6)
        ),
        new Livre(
            titre: "L'Étranger",
            prix: 7.20m,
            nombrePage: 186,
            parution: new DateTime(1942, 5, 19)
        ),
        new Livre(
            titre: "1984",
            prix: 9.90m,
            nombrePage: 328,
            parution: new DateTime(1949, 6, 8)
        ),
        new Livre(
            titre: "Les Misérables",
            prix: 14.90m,
            nombrePage: 100,
            parution: new DateTime(1862, 4, 3)
        ),
        new Livre(
            titre: "Harry Potter à l'école des sorciers",
            prix: 10.50m,
            nombrePage: 308,
            parution: new DateTime(1998, 10, 9)
        ),
        new Livre(
            titre: "Le Seigneur des Anneaux",
            prix: 24.90m,
            nombrePage: 499,
            parution: new DateTime(1954, 7, 29)
        ),
        new Livre(
            titre: "Clean Code",
            prix: 39.99m,
            nombrePage: 464,
            parution: new DateTime(2008, 8, 1)
        ),
        new Livre(
            titre: "The Pragmatic Programmer",
            prix: 42.50m,
            nombrePage: 352,
            parution: new DateTime(1999, 10, 20)
        )
    };
}