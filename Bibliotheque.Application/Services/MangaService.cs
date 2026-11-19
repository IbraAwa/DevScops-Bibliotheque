using Bibliotheque.Application.Exceptions;
using Bibliotheque.Application.Repositories;
using Bibliotheque.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Application.Services;

// Chaque class service à son interface IService
// Pourquoi ?
// Pour pouvoir l'injecter via les autres couche

public interface IMangaService
{
    public IEnumerable<Manga> GetAll();
    public void Create(string titre, string genre, decimal prix);
}

// un service possède la logique dans notre cas
public class MangaService : IMangaService
{
    private readonly IMangaRepository _mangaRepository;

    public MangaService(IMangaRepository mangaRepository)
    {
        _mangaRepository = mangaRepository;
    }

    // on doit vérifier que le prix n'est pas au dessus de 20€
    // on doit vérifier que le genre n'est pas horreur 
    public void Create(string titre, string genre, decimal prix)
    {
        try
        {
            if (prix > 20)
            {
                // avoir des erreurs explicite
                throw new PrixTropEleverException("Le prix du manga est trop élevé");
            }

            if (genre.ToLower() == "horreur")
            {
                Console.WriteLine("Le genre est horreur alors que c'est interdit");
            }

            Manga manga = new(titre, genre, prix);
            _mangaRepository.Create(manga);
        }
        catch (PrixTropEleverException ex)
        {
            Console.WriteLine();
            Console.WriteLine(ex.InnerException);
            Console.WriteLine();
        }
    }

    public IEnumerable<Manga> GetAll()
    {
        return _mangaRepository.GetAll();
    }
}
