namespace  Inheritance_and_polymorphism;
class Program
{
    /* Kontrolspørgsmål
     * 1. Det kan man se på keywordet "override" på de metoder der bliver overskrevet
     * 2. Den vil bruge kaldet fra forældre klassen med mindre man bruger keywordet "new"
     * for at fortælle compileren at vi ønsker at erstatte den nedarvede metode med den nye
     * 3. Den vælger den afhængig af hvor mange argumenter der er og hvad type de argumenter er
     * 4. Nej, fordi override kan ikke fjerne/tilføje argumenter. Den skal være nøjagtig magen til den man overrider
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
        
        Console.WriteLine($"Samlet løn: {totalPay} kr.");

        var salaryCalculator = new SalaryCalculator();
        
        Console.WriteLine($"base bonus: {salaryCalculator.CalculateBonus(20000)}");
        Console.WriteLine($"Percentage bonus: {salaryCalculator.CalculateBonus(20000, 0.07m)}");
        Console.WriteLine($"Seniority bonus: {salaryCalculator.CalculateBonus(20000, 0.07m, 5)}");
    }
}