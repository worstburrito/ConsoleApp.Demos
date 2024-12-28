
using System;
using System.Globalization;

// declare variables - name and age
string? firstName = string.Empty;
string lastName = string.Empty;
int age;
DateOnly dob = new DateOnly();

decimal salary = 0;
char gender = char.MinValue;
bool working;
char choice = char.MinValue;

List<Person> persons = new List<Person>();
while (choice != 'E' )
{
    // prompt the user for input
    Console.Write("Please enter your first name: ");
    firstName = Console.ReadLine();

    Console.Write("Please enter your last name: ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your date of birth (dd/mm/yyyy): ");
    dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);

    Console.Write("Please enter your salary: ");
    salary = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Please enter your gender as 'M', 'F', or 'O' (for other): ");
    gender = Convert.ToChar(Console.ReadLine());

    Console.Write("Are you currently employed? 'true' or 'false': ");
    working = Convert.ToBoolean(Console.ReadLine());

    Person person = new(dob)
    {
        FirstName = firstName,
        LastName = lastName,
        Gender = gender,
        IsWorking = working,
        Salary = salary
    };

    persons.Add(person);

    Console.WriteLine($"'C' to continue... 'E' to exit...");
    choice = Convert.ToChar(Console.ReadLine());
}

foreach (Person person in persons)
{
    // output the results
    Console.WriteLine($"\nFull name: {person.ToString()}\n" +
        $"Age: {person.GetAge()}\n" +
        $"Salary: {person.Salary:C}\n" +
        $"Gender: {person.Gender}\n" +
        $"Currently employed: {person.IsWorking}\n" +
        $"Working years remaining: {person.GetNumberOfWorkingYearsRemaining()}\n" +
        $"Estimated Retirement Year: {person.GetEstimatedRetirementDate()}\n\n");
}


