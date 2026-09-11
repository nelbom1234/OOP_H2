namespace Heltevagten;

class Program
{
    static void Main(string[] args)
    {
        var heroes = new List<Hero>
        {
            new Goku("Goku"),
            new Gohan("Gohan"),
            new Krillin("Krillin"),
        };

        var dispatchStrategy = new FirstAvailableStrategy();

        var incidents = new List<Incident>
        {
            new Incident("Fire", "Copenhagen", eSeverity.High),
            new Incident("Bank robbery", "Odense", eSeverity.Medium),
            new Incident("Hostage situation", "Aarhus", eSeverity.Critical),
        };

        var dispatchCenter = new DispatchCenter(heroes, incidents, dispatchStrategy);

        var (hero, incident, resolveIncident) = dispatchCenter.AssignHeroToNextIncident();

        resolveIncident(incident);

    }
}