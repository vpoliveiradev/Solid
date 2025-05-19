namespace Solid._04_ISP.Good;

using Solid._04_ISP.Good.Interfaces;

public class ContractEmployee : ISalaryCalculator
{
    public void CalculateSalary()
    {
        Console.WriteLine("Calculating salary for contract employee.");
    }
}