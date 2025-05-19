namespace Solid._04_ISP.Good;

using Solid._04_ISP.Good.Interfaces;

public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
{
    public void CalculateSalary()
    {
        Console.WriteLine("Calculating salary for full-time employee");
    }

    public void CalculateBenefits()
    {
        Console.WriteLine("Calculating benefits for full-time employee");
    }
}