// See https://aka.ms/new-console-template for more information
// Define a Class
using System.Security.Cryptography;

public class Person
{
    // Constructors
    public Person()
    {
        // Default version: Person baby = new Person();
        // This would require the Program itself to fill in the blanks after initiated.

    }

    public Person(string firstName, string lastName, DateOnly dob)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
    }

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }

    // Properties/Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }


    // Field Member
    private string _taxNumber;
    protected string _idNumber = "N/A";

    // Methods
    public void PrintFullName()
    {
        Console.WriteLine($"Full name: {FirstName} {LastName}");
    }

    public void PrintIntials()
    {
        var firstIntial = FirstName[0];
        var lastInitial = LastName[0];
        Console.WriteLine($"Initials: {firstIntial}.{lastInitial}.");
    }

    public void GenerateTaxNumber()
    {
        if (string.IsNullOrEmpty(_taxNumber))
        {
            _taxNumber = GetRandomNumber();
        }
        else
        {
            Console.WriteLine($"Tax number already exists.");
        }
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }

    public int GetAge()
    {
        var age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }

    public int GetAge(int year)
    {
        var age = year - DateOfBirth.Year;
        return age;
    }

    protected string GetRandomNumber()
    {
        return RandomNumberGenerator
            .GetInt32(100000, 9999999)
            .ToString();
    }
}