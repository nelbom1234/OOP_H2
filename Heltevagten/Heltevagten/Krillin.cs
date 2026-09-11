namespace Heltevagten;

public class Krillin : Hero, ISuperStrong
{
    public Krillin(string name) : base(name)
    {
    }
    
    public override string UseSignatureMove()
    {
        return $"{Name} uses destructo disc";
    }

    public string LiftHeavyObject()
    {
        return $"{Name}  lifts a heavy object";
    }
}