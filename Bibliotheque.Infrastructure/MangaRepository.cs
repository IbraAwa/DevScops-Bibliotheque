using Bibliotheque.Application;
using Bibliotheque.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Infrastructure;

public class MangaRepository : IMangaRepository
{
    public void Create(Manga manga)
    {
        MangasData.Mangas.Add(manga);
    }

    public IEnumerable<Manga> GetAll()
    {
        return MangasData.Mangas;
    }
}
