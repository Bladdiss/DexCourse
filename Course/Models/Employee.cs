namespace Models;

public class Employee : Person
{
    public string Contract { get; private set; }
    public int Salary { get; private set; }

    public Employee(string firstName, string lastName, string contract, int salary) : base(firstName, lastName)
    {
        SetContract(contract);
        Salary = salary;
    }

    public void SetContract(string contract)
    {
        Contract = contract;
    }
}