namespace Heltevagten;

public class Gohan : Hero, ISuperSaiyan
{
    public Gohan(string name) : base(name)
    {
    }
    
    public override string UseSignatureMove()
    {
        return $"{Name} uses Kamehameha";
    }

    public string GoSuperSaiyan()
    {
        return $"{Name} goes super saiyan";
    }
}