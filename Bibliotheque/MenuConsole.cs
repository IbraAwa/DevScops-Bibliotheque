using Bibliotheque.Application;
using Bibliotheque.Domain;

namespace Bibliotheque.App
{
    public class MenuConsole
    {

        // Pourquoi j'injecte une interface et pas une classe ?
        //
        // L'interface est un contrat : elle dit seulement QUELLES méthodes existent
        // (ex. Create), pas COMMENT elles fonctionnent.
        //
        // MenuConsole ne connaît donc pas la classe concrète (LivreService).
        // C'est le conteneur d'injection de dépendances qui choisit laquelle fournir.
        //
        // Avantages :
        //   - Faible couplage : je peux changer d'implémentation sans toucher à MenuConsole.
        //   - Tests unitaires : je peux passer un faux service (mock) à la place du vrai,
        //     pour tester le menu sans dépendre de la vraie logique métier ni des données.
        private readonly ILivreService _livreService;
        private readonly IMangaService _mangaService;

        public MenuConsole(ILivreService livreService, IMangaService mangaService)
        {
            _livreService = livreService;
            _mangaService = mangaService;
        }

        public void Run()
        {
            bool mod = true;

            while (mod)
            {
                Console.WriteLine("Quel action voulez-vous faire ?");
                Console.WriteLine("1) Crée un livre");
                Console.WriteLine("2) Crée un manga");
                Console.WriteLine("3) Récupérer tout mes mangas");
                int action = int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    Console.WriteLine("Quel est le titre de votre livre ?");
                    string titre = Console.ReadLine();

                    Console.WriteLine("Nombre de page ?");
                    int nombrePage = int.Parse(Console.ReadLine());
                    _livreService.Create(titre, nombrePage);
                }
                else if (action == 2)
                {
                    Console.WriteLine("Quel est le titre du manga ?");
                    string titreManga = Console.ReadLine();

                    Console.WriteLine("Quel genre est votre manga ?");
                    string genreManga = Console.ReadLine();

                    Console.WriteLine("Quel est le prix de votre manga ?");
                    decimal prixManga = decimal.Parse(Console.ReadLine());

                    _mangaService.Create(titreManga, genreManga, prixManga);
                }
                else if (action == 3)
                {
                    IEnumerable<Manga> mangas = _mangaService.GetAll();

                    foreach (Manga manga in mangas)
                    {
                        Console.WriteLine($"{manga.Titre} - {manga.Prix}");
                        Console.WriteLine();
                    }

                }

                Console.WriteLine("voulez-vous arrêter l'app ? (o/n)");
                string choix = Console.ReadLine();
                if(choix == "o")
                {
                    mod = false;
                } else
                {
                    mod = true;
                }
            }
        }
    }
}
