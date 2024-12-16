// Step one: declare variables - name and age
string name = string.Empty;
int age = 0;
int retireAge = 65;

// Step two: prompt the user for input
Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Step three: find retirement years left
int yearsToRetire = retireAge - age;

// Step four: output user input
Console.WriteLine($"\nYour name is {name} and you are {age} years old. You have {yearsToRetire} years until you can retire.");
