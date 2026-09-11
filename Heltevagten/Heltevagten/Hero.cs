namespace Heltevagten;

public abstract class Hero
{
    public Hero(string name)
    {
        Name = name;
        EnergyLevel = 100;
        IsAvailable = true;
    }
    
    public string Name { get; private set; }

    public int EnergyLevel { get; private set; }
    
    public bool IsAvailable { get; private set; }

    public void AssignToIncident()
    {
        IsAvailable = false;
    }

    public void DoneWithIncident()
    {
        IsAvailable = true;
    }
    
    private void IncreaseEnergy(int value)
    {
        EnergyLevel += value;
        if (EnergyLevel > 100)
        {
            EnergyLevel = 100;
        }
    }

    private bool UseEnergy(int value)
    {
        if (value > EnergyLevel)
        {
            return false;
        }

        EnergyLevel -= value;
        return false;
    }

    public abstract string UseSignatureMove();
}