using Models;
using Services;

namespace PracticeWithTypes;

class Program
{
    private static void Main()
    {
        var employee = new Employee("Эдуард", "Беккер", "Слесарь ", 1000);
        var currency = new Currency("USD", 16.50m);

        var newContract = "Водитель";
        UpdateEmployeeContract(employee, newContract);

        var newName = "EUR";
        var newPrice = 20.01m;
        ReplaceCurrency(ref currency, newName, newPrice);

        Console.WriteLine($"Обновленный контракт : {employee.Contract}");
        Console.WriteLine($"Обновленная валюта : {currency.Name} {currency.ToDollar}");

        var owners = new List<Employee>
        {
            new Employee("Андрей", "Кожокарь", "Слесарь", 1000),
            new Employee("Даниил", "Колотушкин", "Слесарь", 1000)
        };

        var apb = new BankService();
        apb.CalculateSalary(owners, 20000, 10000);

        foreach (var owner in owners)
        {
            Console.WriteLine($"Владелец: {owner.FirstName} {owner.LastName} {owner.Salary}");
        }

        var client = new Client("Игорь ", "Киселев");
        employee = apb.ConvertClientToEmployee(client);

        Console.WriteLine($"Новый сотрудник : {employee.FirstName} {employee.LastName}");
        Console.WriteLine($"Зарплата : {employee.Salary}  Должность: {employee.Contract}");
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