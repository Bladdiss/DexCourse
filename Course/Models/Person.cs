namespace Models;

public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    protected Person(string firstName, string lastName)
    {
        SetFirstName(firstName);
        SetLastName(lastName);
    }

    private void SetFirstName(string firstName)
    {
        if (string.IsNullOrEmpty(firstName))
        {
            throw new ArgumentNullException(nameof(firstName));
        }

        FirstName = firstName;
    }

    private void SetLastName(string lastName)
    {
        if (string.IsNullOrEmpty(lastName))
        {
            throw new ArgumentNullException(nameof(lastName));
        }

        LastName = lastName;
    }
}