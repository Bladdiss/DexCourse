namespace Models;

public class Employee : Person
{
    public string Contract { get; private set; }
    public decimal Salary { get; private set; }

    public Employee(string firstName, string lastName, string contract, decimal salary) : base(firstName, lastName)
    {
        SetContract(contract);
        SetSalary(salary);
    }

    public void SetContract(string contract)
    {
        if (string.IsNullOrEmpty(contract))
        {
            throw new ArgumentNullException(nameof(contract));
        }

        Contract = contract;
    }

    public void SetSalary(decimal salary)
    {
        if (salary < 0)
        {
            throw new ArgumentException("Salary cannot be negative");
        }

        Salary = salary;
    }
}