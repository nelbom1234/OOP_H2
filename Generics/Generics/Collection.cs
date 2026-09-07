using System.Text;

namespace Generics;

public class Collection<T>
{
    private List<T> List { get; set; }

    /// <summary>
    /// The number of elements in the collection
    /// </summary>
    public int Count => List.Count;
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="list">The initial list</param>
    public Collection(List<T> list)
    {
        List = list;
    }

    /// <summary>
    /// Adds an element to the collection
    /// </summary>
    /// <param name="element">The element to add</param>
    public void Add(T element)
    {
        List.Add(element);
    }

    /// <summary>
    /// Removes an element from the collection
    /// </summary>
    /// <param name="element">The element to remove</param>
    public bool Remove(T element)
    {
        return List.Remove(element);
    }
    
    /// <summary>
    /// Finds the first element of the collection based on a predicate
    /// </summary>
    /// <param name="predicate">The predicate for finding the element</param>
    /// <returns>The first element matching the predicate, or default if none found</returns>
    public T? Find(Func<T, bool> predicate)
    {
        foreach (var elem in List)
        {
            if (predicate(elem)) return elem;
        }

        return default(T);
    }

    /// <summary>
    /// Returns a string with each element separated by commas
    /// </summary>
    /// <returns>The string representation of the collection</returns>
    public override string ToString()
    {
        var builder = new StringBuilder();

        foreach (var val in List)
        {
            builder.Append($"{val}, ");
        }
        
        return builder.ToString();
    }
}