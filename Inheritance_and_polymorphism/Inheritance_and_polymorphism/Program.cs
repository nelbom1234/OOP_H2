namespace  Inheritance_and_polymorphism;
class Program
{
    /* Kontrolspørgsmål
     * 1. Det kan man se på keywordet "override" på de metoder der bliver overskrevet
     * 2. It will use the call from the parent class unless you use the keyword "new"
     * to tell the compiler that it should replace the inherited method with the new method
     */
    
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new SalariedEmployee("Jens", "1", DateTime.Now, 30000, 10000),
            new SalariedEmployee("Jørgen", "2", DateTime.Now, 25000, 20000),
            new HourlyEmployee("Trine", "3", DateTime.Now, 180, 160),
            new HourlyEmployee("Brian", "4", DateTime.Now, 210, 145),
        };

        decimal totalPay = 0;
        foreach (var employee in employees)
        {
            totalPay += employee.CalculateSalary();
            Console.WriteLine(employee.Description());
        }
        
        Console.WriteLine("Samlet løn: {0} kr.",totalPay);
    }
}