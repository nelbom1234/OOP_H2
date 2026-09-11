namespace Heltevagten;

public class NoSuitableHeroFoundException : Exception
{
    public NoSuitableHeroFoundException(string message, Exception? innerException = null) : base(message, innerException)
    {
    }
}