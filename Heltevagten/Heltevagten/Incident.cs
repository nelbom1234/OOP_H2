namespace Heltevagten;

public class Incident
{
    public Incident(
        string description,
        string location,
        eSeverity severity)
    {
        Description = description;
        Location = location;
        Severity = severity;
        IsResolved = false;
    }
    
    public string Description { get; private set; }
    
    public string Location { get; private set; }
    
    public eSeverity Severity { get; private set; }
    
    public bool IsResolved { get;  private set; }

    public void ResolveIncident()
    {
        IsResolved = true;
    }
}