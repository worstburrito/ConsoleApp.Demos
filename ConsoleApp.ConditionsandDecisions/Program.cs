// Get input
Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Decide to print pass or fail based on grade
Console.WriteLine("\n********** SIMPLE IF RESULTS START **********\n");
if (grade > 50)
{
    Console.WriteLine("Student has passed.");
} else
{
    Console.WriteLine("Student has failed.");
    Console.WriteLine("Please refer student to Student Affair's Office.");
}
Console.WriteLine("\n********** SIMPLE IF RESULTS END **********\n");

// Conditional IF version of program with letter grade
Console.WriteLine("\n********** IF, ELSE IF, ELSE START **********\n");
if (grade < 0 || grade > 100)
{
    Console.WriteLine($"{grade} is an invalid entry for this grading system.");
} else if (grade <= 64)
{
    Console.WriteLine("Student Grade: F");
} else if (grade > 64 && grade <= 69)
{
    Console.WriteLine("Student Grade: D");
} else if (grade >= 70 && grade <= 79 )
{
    Console.WriteLine("Student Grade: C");
} else if (grade >= 80 && grade <= 89)
{
    Console.WriteLine("Student Grade: B");
} else if (grade >= 90)
{
    Console.WriteLine("Student Grade: A");
} 
Console.WriteLine("\n********** IF, ELSE IF, ELSE END **********\n");

// Ternary operators
Console.WriteLine("\n********** TERNARY OPERATOR START **********\n");
string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Test Results: {passStatus}");

Console.WriteLine("\n********** TERNARY OPERATOR END **********\n");

// Switch Statements
Console.WriteLine("\n********** SWITCH STATEMENTS START **********\n");
Console.WriteLine("Please enter a day of the week number Sunday (1) - Saturday (7): ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        Console.WriteLine("Hump Day!!");
        break;
    case 5:
        Console.WriteLine("Thursday");
        Console.WriteLine("Almost Friday!!");
        break;
    case 6:
        Console.WriteLine("Friday");
        Console.WriteLine("TGIF!!");
        break;
    case 7:
        Console.WriteLine("Saturday");
        Console.WriteLine("Beach day!!!");
        break;
    default:
        Console.WriteLine("Invalid day of week number!");
        break;
}

Console.WriteLine("\n********** SWITCH STATEMENTS END **********\n");
