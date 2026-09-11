namespace Heltevagten;

public interface IDispatchStrategy
{
    public Hero? SelectHero(Incident incident, List<Hero> availableHeroes);
}