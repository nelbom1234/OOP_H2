namespace Inheritance_and_polymorphism;

public class SalaryCalculator
{
    public decimal CalculateBonus(decimal baseSalary)
    {
        return baseSalary * 0.05m;
    }
    public decimal CalculateBonus(decimal baseSalary, decimal percentage)
    {
        return baseSalary * percentage;
    }
    public decimal CalculateBonus(decimal baseSalary, decimal percentage, int yearsOfSeniority)
    {
        var totalBonus = percentage + 0.01m * yearsOfSeniority;
        return baseSalary * totalBonus;
    }
}