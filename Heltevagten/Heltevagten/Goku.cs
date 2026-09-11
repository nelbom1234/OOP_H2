namespace Heltevagten;

public class Goku : Hero, ISuperSaiyan, ISuperStrong
{
    public Goku(string name) : base(name)
    {
    }
    
    public override string UseSignatureMove()
    {
        return $"{Name} uses Spirit bomb";
    }

    public string GoSuperSaiyan()
    {
        return $"{Name} goes super saiyan";
    }

    public string LiftHeavyObject()
    {
        return $"{Name} lifts a heavy object";
    }
}