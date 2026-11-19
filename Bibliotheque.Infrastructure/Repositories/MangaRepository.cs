using Bibliotheque.Application.Repositories;
using Bibliotheque.Domain;
using Bibliotheque.Infrastructure.Datas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Infrastructure.Repositories;

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
