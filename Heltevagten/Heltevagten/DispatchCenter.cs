namespace Heltevagten;

public class DispatchCenter
{
    public DispatchCenter(
        List<Hero> heroes,
        List<Incident> incidents,
        IDispatchStrategy dispatchStrategy)
    {
        Heroes = heroes;
        Incidents = incidents;
        DispatchStrategy = dispatchStrategy;
    }
    
    private List<Hero> Heroes { get; set; }
    
    private List<Incident> Incidents { get; set; }
    
    private IDispatchStrategy DispatchStrategy { get; set; }

    public void RegisterHero(Hero hero)
    {
        Heroes.Add(hero);
    }

    public void ReportIncident(Incident incident)
    {
        Incidents.Add(incident);
    }

    public Hero AssignHeroToNextIncident()
    {
        var nextIncident = Helper.FindFirst(Incidents, incident => !incident.IsResolved);

        if (nextIncident == null)
        {
            throw new NoUnresolvedIncidentsException("All currently reported incidents are resolved");
        }

        var assignedHero = DispatchStrategy.SelectHero(nextIncident, Heroes);

        if (assignedHero == null)
        {
            throw new NoSuitableHeroFoundException("No suitable hero found for incident");
        }
        
        assignedHero.AssignToIncident();

        return assignedHero;
    }

    private void ResolveIncident(Incident incident, Action<Incident> action)
    {
        incident.ResolveIncident();
    }
}