using Models;

namespace Services;

public class BankService
{
    public void SalaryCalculation(List<Employee> owners, int bankProfit, int bankExpenses)
    {
        ArgumentNullException.ThrowIfNull(owners, "You must provide at least one employee.");
        ArgumentOutOfRangeException.ThrowIfNegative(
            bankProfit,
            "The bank profit must be greater than or equal to zero.");
        ArgumentOutOfRangeException.ThrowIfNegative(
            bankExpenses,
            "The bank expenses must be greater than or equal to zero.");

        var netProfit = bankProfit - bankExpenses;
        var incomePerOwner = netProfit / owners.Count;

        foreach (var owner in owners)
        {
            owner.SetSalary(incomePerOwner);
        }
    }

    public Employee ConvertClientToEmployee(Client client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return new Employee(
            firstName: client.FirstName,
            lastName: client.LastName,
            contract: "Слесарь",
            salary: 0);
    }
}