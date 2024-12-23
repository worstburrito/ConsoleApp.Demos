// See https://aka.ms/new-console-template for more information



Console.WriteLine($"\n\n********** METHODS/FUNCTIONS **********\n\n");


// Void Methods - completes a task without returning a value
void PrintName()
{
    // Method Code:
    Console.WriteLine("Rachael Pracht");
}


// Value Returning Methods - returns a value after an operation
int GetFivesYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}


// Methods with Parameters
void PrintNameWithParameters(string name)
{
    // Method Code:
    Console.WriteLine($"Your name is: {name}");
}

int GetYearDifferenceWithParameters(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}



// Methods with Optional Parameters
int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}


// Methods with Nullable Parameters
void PrintNameNullableParam(string? name, int? count)
{
    //if (string.IsNullOrEmpty(name))
    //{
    //    name = "Default Name";
    //}

    name ??= "Default Name";


    //if (count.HasValue == false)
    //{
    //    count = 1;
    //}

    count ??= 1;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}





/* Function Calls */

// Void Methods
Console.WriteLine($"\n\n~~~ Void Method Calls ~~~");

PrintName();


// Return Methods
Console.WriteLine($"\n\n~~~ Returm Method Calls ~~~");

int fiveYearsAgo = GetFivesYearsAgo();
Console.WriteLine($"Five years ago was: {fiveYearsAgo}");


// Methods with Parameters
Console.WriteLine($"\n\n~~~ Parameter Method Call 1 ~~~");

Console.Write($"Please enter your name: ");
string name = Console.ReadLine();
PrintNameWithParameters(name);

Console.WriteLine($"\n\n~~~ Parameter Method Call 2 ~~~\n\n");

Console.Write($"Enter a year: ");
int pastYear = Convert.ToInt32(Console.ReadLine());
int yearsAgo = GetYearDifferenceWithParameters(pastYear);
Console.WriteLine($"{pastYear} was {yearsAgo} years ago.");


// Optional Parameter Methods
Console.WriteLine($"\n\n~~~ Optional Parameter Methods ~~~");

Console.Write("Enter number of years in the future or past: ");
int numberOfYears = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n\n~~~ Call 1 Without Parameter ~~~\n\n");
var pastYear1 = GetFutureOrPastYear();
Console.WriteLine($"The year is {pastYear1}");

Console.WriteLine($"\n\n~~~ Call 1 With Parameter ~~~\n\n");
var pastYear2 = GetFutureOrPastYear(numberOfYears);
Console.WriteLine($"The year is {pastYear2}");


// Nullable Parameters
Console.WriteLine($"\n\n~~~ Nullable Method Calls ~~~");

Console.WriteLine($"\n\n~~~ With Null Params ~~~\n\n");
PrintNameNullableParam(null, null);

Console.WriteLine($"\n\n~~~ With Params ~~~\n\n");
PrintNameNullableParam("Rachael", 5);
