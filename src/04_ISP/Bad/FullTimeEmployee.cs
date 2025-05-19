namespace Solid._04_ISP.Bad;

using Solid._04_ISP.Bad.Interfaces;

public class FullTimeEmployee : IEmployee
{
    public void CalculateSalary()
    {
        // Implementation for calculating salary

        Console.WriteLine("Calculating salary for full-time employee.");
    }

    public void CalculateBenefits()
    {
        // Implementation for calculating benefits
        Console.WriteLine("Calculating benefits for full-time employee.");
    }
}