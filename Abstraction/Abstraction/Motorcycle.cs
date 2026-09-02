namespace Abstraction;

public class Motorcycle : Vehicle
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

    // Bemærk: Motorcycle overrider IKKE CalculateAnnualTax().
    // Det er helt lovligt - så bruges basisklassens standardversion (1000m)
    // automatisk, når CalculateAnnualTax() kaldes på et Motorcycle-objekt.
}