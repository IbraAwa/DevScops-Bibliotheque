using Bibliotheque.Application.Repositories;
using Bibliotheque.Domain.Entities;

namespace Bibliotheque.Application.Services;


public interface ILivreService
{
    public void GetAllBetweenPageNumber();
    public void Create(string name, int nombrePage);

    public void Update(string name, int nombrePage);
}


// Ne s'occupe pas de savoir comment ou avec qui il récupère un livre
// il regarde si le livre qu'on enregistre respecte les règles métier
// et ensuite demande soit de trouver / crée / modifier un livre
// livreRepository
public class LivreService : ILivreService
{
    // si vous injecter des classes concrète
    // vous lier votre classe et son injection à la logique
    // quand vous voudrez faire des test unitaire
    // vous devrez tester la logique de votre infa + celle du service
    // X private readonly MaClassConcrete _ClassConcrete; 


    private readonly ILivreRepository _livreRepository;

    public LivreService(ILivreRepository livreRepository)
    {
        _livreRepository = livreRepository;
    }

    public void GetAllBetweenPageNumber()
    {
        // récupération de tout les livres
        List<string> livres = new List<string>(); 

        // vous faite votre linq pou récupérer seulement entre page 400 et 500
    }

    // un livre ne peut pas dans ma bibliothèqe excédé 500pages
    public void Create(string titre, int nombrePage)
    {
        Livre livre = new(titre, null, nombrePage, null);
        NumberPageMaximumRespected(nombrePage);
        _livreRepository.Create(livre);
    }


    public void Update(string titre, int nombrePage) {
        NumberPageMaximumRespected(nombrePage);
    }

    // DRY 
    // centraliser une logique trop répété à un seul endroit
    // PERMET :
    // De éclaircir le code en ayant moin de ligne
    // et d'évité d'oublier une partie de code avec la même logique
    // évite que le message d'erreur soit différent à chaque fois

    // en private
    // comme ça on ne l'appel pas dans une autre classe
    // evité les effets de bord
    private void NumberPageMaximumRespected(int nombrePage) {
        if (nombrePage > 500)
        {
            // une erreur doit toujours être explicite
            // Sauf en cas de connexion ou la vous devez être vague
            // pourquoi ? ne pas donner d'indice au cyberAttaquant
            Console.WriteLine("Le nombre de page d'un livre doit être en-dessous de 500");
        }
    }

}
