using Bibliotheque.Application.Repositories;
using Bibliotheque.Domain.Entities;
using Bibliotheque.Infrastructure.Datas;

namespace Bibliotheque.Infrastructure.Repositories;


// implémentera mon interface ILivreRepository et y ajoutera la logique
internal class LivreRepository : ILivreRepository
{

    // respect du  single responsability
    // pourquoi ?
    // elle s'occupe juste de crée un livre
    // et elle a seulement une raison de changer
    // si tu change la DB ou le nom de la table etc..
    public void Create(Livre livre)
    {
        LivresData.Livres.Add(livre);
    }
}
