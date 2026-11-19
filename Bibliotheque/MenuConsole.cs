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
        public MenuConsole(ILivreService livreService)
        {
            _livreService = livreService;
        }

        public void Run()
        {
            Console.WriteLine("Quel action voulez-vous faire ?");
            Console.WriteLine("1) Crée un livre");
            int action = int.Parse(Console.ReadLine());

            if(action == 1)
            {
                Console.WriteLine("Quel est le titre de votre livre ?");
                string titre = Console.ReadLine();

                Console.WriteLine("Nombre de page ?");
                int nombrePage = int.Parse(Console.ReadLine());
                _livreService.Create(titre, nombrePage);
            }
        }
    }
}
