namespace Heltevagten;

public class Helper
{
    public static T? FindFirst<T>(List<T> items, Func<T, bool> predicate)
    {
        return items.FirstOrDefault(predicate);
    }
}