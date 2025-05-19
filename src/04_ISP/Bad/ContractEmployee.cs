namespace Solid._04_ISP.Bad;

using Solid._04_ISP.Bad.Interfaces;

public class ContractEmployee : IEmployee
{
    public void CalculateSalary()
    {
        // Implementation for calculating salary
        Console.WriteLine("Calculating salary for contract employee.");
    }

    public void CalculateBenefits()
    {
        // Contract employees do not have
        throw new NotImplementedException("Contract employees do not have benefits.");

    }
}