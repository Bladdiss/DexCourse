using Models;

namespace Services;

class Program
{
    static void Main(string[] args)
    {
        var employee = new Employee("Эдуард", "Беккер", "Слесарь ", 1000);
        var currency = new Currency("USD", (decimal)16.50);

        var newContract = "Водитель";
        UpdateEmployeeContract(employee, newContract);

        var newName = "EUR";
        var newPrice = (decimal)20.01;
        ReplaceCurrency(ref currency, newName, newPrice);

        Console.WriteLine($"Обновленный контракт : {employee.Contract}");
        Console.WriteLine($"Обновленная валюта : {currency.Name} {currency.ToDollar}");

        var owners = new List<Employee>
        {
            new Employee("Андрей", "Кожокарь", "Слесарь", 1000),
            new Employee("Даниил", "Колотушкин", "Слесарь", 1000)
        };

        var qBank = new BankService();
        qBank.SalaryCalculation(owners, 20000, 10000);

        foreach (var owner in owners)
        {
            Console.WriteLine($"Владелец: {owner.FirstName} {owner.LastName} {owner.Salary}");
        }

        var client = new Client("Игорь ", "Киселев");
        employee = qBank.ConvertClientToEmployee(client);

        Console.WriteLine(
            $"Новый сторудник : {employee.FirstName} {employee.LastName} \nЗарплата : {employee.Salary}  Должность: {employee.Contract}");
    }

    private static void UpdateEmployeeContract(Employee employee, string newContract)
    {
        employee.SetContract(newContract);
    }

    private static void ReplaceCurrency(ref Currency currency, string newName, decimal newValue)
    {
        currency.SetName(newName);
        currency.SetPrice(newValue);
    }
}