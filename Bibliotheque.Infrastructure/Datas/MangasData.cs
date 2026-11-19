using Bibliotheque.Domain;

namespace Bibliotheque.Infrastructure.Datas;

public class MangasData
{
    // TODO : créer l'entité Manga dans Bibliotheque.Domain, puis décommenter la liste ci-dessous.
    //
    // L'entité doit avoir un constructeur avec ces paramètres :
    //   - string titre
    //   - string genre   → ne peut pas être "Horreur"
    //   - decimal prix   → ne peut pas dépasser 20 €
    //
    // Astuce Visual Studio : sélectionner le bloc puis Ctrl+K, Ctrl+U pour décommenter.

    public static List<Manga> Mangas { get; set; } = new List<Manga>
     {
         // Toujours indenter
         new Manga(
             titre: "One Piece",
             genre: "Aventure",
             prix: 6.90m
         ),
         new Manga(
             titre: "Naruto",
             genre: "Action",
             prix: 6.90m
         ),
         new Manga(
             titre: "Dragon Ball",
             genre: "Action",
             prix: 19.90m
         ),
         new Manga(
             titre: "Death Note",
             genre: "Thriller",
             prix: 7.20m
         ),
         new Manga(
             titre: "Spy x Family",
             genre: "Comédie",
             prix: 6.99m
         ),
         new Manga(
             titre: "Fullmetal Alchemist",
             genre: "Fantasy",
             prix: 15.50m
         ),
         new Manga(
             titre: "Demon Slayer",
             genre: "Action",
             prix: 7.20m
         ),
         new Manga(
             titre: "Haikyū!!",
             genre: "Sport",
             prix: 6.90m
         ),
         new Manga(
             titre: "My Hero Academia",
             genre: "Super-héros",
             prix: 6.95m
         ),
         new Manga(
             titre: "Hunter x Hunter",
             genre: "Aventure",
             prix: 6.90m
         )
     };
}