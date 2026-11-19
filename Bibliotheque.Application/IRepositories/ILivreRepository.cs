using Bibliotheque.Domain.Entities;

namespace Bibliotheque.Application.Repositories;

// une interface qui possédera toute les méthode pour pouvoir
// manipuler mes livres (CRUD => create read update delete)
public interface ILivreRepository
{
    public void Create(Livre livre);
}
