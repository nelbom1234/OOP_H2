namespace Inheritance_and_polymorphism;

public class Employee
{
    public Employee(
        string name,
        string employeeId,
        DateTime hireDate)
    {
        Name = name;
        EmployeeId = employeeId;
        HireDate = hireDate;
    }
    
    private string Name { get; set; }
    
    private string EmployeeId { get; set; }
    
    private DateTime HireDate { get; init; }

    public virtual decimal CalculateSalary()
    {
        throw new NotImplementedException();
    }

    public virtual string Description()
    {
        return $"{Name} tjener {CalculateSalary()} kr. om måneden.";
    }
}