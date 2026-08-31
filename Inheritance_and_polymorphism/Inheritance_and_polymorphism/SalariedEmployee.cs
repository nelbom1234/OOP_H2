namespace Inheritance_and_polymorphism;

public class SalariedEmployee : Employee
{
    public SalariedEmployee(
        string name,
        string employeeId,
        DateTime hireDate,
        decimal baseSalary,
        decimal bonus)
    : base(name, employeeId, hireDate)
    {
        BaseSalary = baseSalary;
        Bonus = bonus;
    }
    
    private decimal BaseSalary { get; set; }
    
    private decimal Bonus { get; set; }

    public override decimal CalculateSalary()
    {
        return BaseSalary + Bonus;
    }
}