namespace Bibliotheque.Application.Exceptions;

// crée une exception
// qui renvoie que mon prix est trop élevé
internal class PrixTropEleverException : Exception
{
    public PrixTropEleverException(string message) : base(message) { }
}
