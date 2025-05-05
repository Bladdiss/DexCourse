namespace Models;

public struct Currency
{
    public string Name { get; private set; }
    public double ToDollar { get; private set; }

    public Currency(string name, double price)
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

    public void SetPrice(double toDollar)
    {
        if (toDollar < 0)
        {
            throw new ArgumentException("Price cannot be negative");
        }
        
        ToDollar = toDollar;
    }
}