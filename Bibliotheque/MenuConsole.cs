using Bibliotheque.Application;
using Bibliotheque.Domain;

namespace Bibliotheque.App
{
    public class MenuConsole
    {

        // pourquoi j'injecte une interface et pas une classe ?
        // j'injecte une interface car elle permet juste de dire
        // tient cette méthode et grâce à ça
        // quand je vais faire un test unitaire je n'aurais pas à me soucier
        // de la logique
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
