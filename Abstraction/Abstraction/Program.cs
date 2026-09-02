namespace Abstraction;

class Program
{
    static void Main(string[] args)
    {
        var udlejelige = new List<IUdlejelig>
        {
            new Car("Ferrari", "Bugatti", 400, 3),
            new Motorcycle("Harley", "Stor", 250, true),
        };

        foreach (var udlejelig in udlejelige)
        {
            Console.WriteLine(udlejelig.BeregnLejepris(5));
        }
    }
}