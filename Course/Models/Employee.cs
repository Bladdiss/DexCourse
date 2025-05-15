namespace Models;

public class Employee : Person
{
    public string Contract { get; private set; }
    public double Salary { get; private set; }

    public Employee(string firstName, string lastName, string contract, double salary) : base(firstName, lastName)
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

    public void SetSalary(double salary)
    {
        if (salary < 0)
        {
            throw new ArgumentException("Salary cannot be negative");
        }

        Salary = salary;
    }
}