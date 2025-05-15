namespace Models;

public struct Currency
{
    public string Name { get; private set; }
    public decimal ToDollar { get; private set; }

    public Currency(string name, decimal price)
    {
        SetName(name);
        SetPrice(price);
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty");
        }

        Name = name;
    }

    public void SetPrice(decimal toDollar)
    {
        if (toDollar < 0)
        {
            throw new ArgumentException("Price cannot be negative");
        }

        ToDollar = toDollar;
    }
}