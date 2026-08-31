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
    
    public string Name { get; private set; }
    
    public string EmployeeId { get; private set; }
    
    public DateTime HireDate { get; init; }

    public virtual decimal CalculateSalary()
    {
        throw new NotImplementedException();
    }

    public virtual string Description()
    {
        return $"{Name} tjener {CalculateSalary()} kr. om måneden.";
    }
}