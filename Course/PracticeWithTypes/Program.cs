using Models;

class Program
{
    static void Main(string[] args)
    {
        var employee = new Employee("Эдуард", "Беккер", "Слесарь ", 1000);
        var currency = new Currency("USD", 16.50);

        var newContract = "Водитель";
        UpdateEmployeeContract(employee, newContract);

        var newName = "EUR";
        var newPrice = 20.01;
        ReplaceCurrency(ref currency, newName, newPrice);

        Console.WriteLine($"Обновленный контракт : {employee.Contract}");
        Console.WriteLine($"Обновленная валюта : {currency.Name} {currency.ToDollar}");
    }

    private static void UpdateEmployeeContract(Employee employee, string newContract)
    {
        employee.SetContract(newContract);
    }

    private static void ReplaceCurrency(ref Currency currency, string newName, double newValue)
    {
        currency.SetName(newName);
        currency.SetPrice(newValue);
    }
}