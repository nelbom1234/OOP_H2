namespace Inheritance_and_polymorphism;

public class HourlyEmployee : Employee
{
    public HourlyEmployee(
        string name,
        string employeeId,
        DateTime hireDate,
        decimal hourlyRate,
        double hoursWorked) 
        : base(name, employeeId, hireDate)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    private decimal HourlyRate { get; set; }
    
    private double HoursWorked { get; set; }

    public override decimal CalculateSalary()
    {
        return HourlyRate * (decimal)HoursWorked;
    }
    
    public void RegisterOvertime(double extraHours)
    {
        HoursWorked += extraHours;
    }
}