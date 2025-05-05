namespace Models;

public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    protected Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        Validate();
    }

    private void Validate()
    {
        if (string.IsNullOrEmpty(FirstName))
        {
            throw new ArgumentNullException(nameof(FirstName));
        }
        if (string.IsNullOrEmpty(LastName))
        {
            throw new ArgumentNullException(nameof(LastName));
        }
    }
}