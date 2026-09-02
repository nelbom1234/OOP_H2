namespace Abstraction;

public class Motorcycle : Vehicle, IUdlejelig
{
    public bool RequiresHelmet { get; set; }

    public Motorcycle(string brand, string model, int topSpeedKmh, bool requiresHelmet)
        : base(brand, model, topSpeedKmh)
    {
        RequiresHelmet = requiresHelmet;
    }

    public override string Description()
    {
        string helmetInfo = RequiresHelmet ? "styrthjelm påkrævet" : "ingen hjelmkrav";
        return base.Description() + $", {helmetInfo}";
    }

    public override decimal BeregnAarsafgift()
    {
        return TopSpeedKmh * 5m;
    }

    public decimal BeregnLejepris(int antalDage)
    {
        return antalDage * 600;
    }
}