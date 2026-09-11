namespace Heltevagten;

public class FirstAvailableStrategy : IDispatchStrategy
{
    public Hero? SelectHero(Incident incident, List<Hero> availableHeroes)
    {
        return Helper.FindFirst(availableHeroes, hero => hero.IsAvailable);
    }
}