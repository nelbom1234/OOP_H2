namespace Heltevagten;

public class NoUnresolvedIncidentsException : Exception
{
    public NoUnresolvedIncidentsException(string message, Exception? innerException = null) : base(message, innerException)
    {
    }
}