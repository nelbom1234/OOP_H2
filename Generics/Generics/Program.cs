namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        var collection = new Collection<int>([5, 2, 7, 4, 1]);
        
        Console.WriteLine(collection);
        
        collection.Add(8);
        
        Console.WriteLine(collection);
        
        collection.Remove(2);
        
        Console.WriteLine(collection);
        
        Console.WriteLine(collection.Find(x => x == 4));
        
        Console.WriteLine(collection.Find(x => x > 9));
    }
}