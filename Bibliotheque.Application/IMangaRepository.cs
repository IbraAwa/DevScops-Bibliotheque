using Bibliotheque.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Application;

public interface IMangaRepository
{
    //
    public IEnumerable<Manga> GetAll();

    public void Create(Manga manga);

}
