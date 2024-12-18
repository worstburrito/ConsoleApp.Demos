// See https://aka.ms/new-console-template for more information

// Weclome Message
Console.WriteLine("*~*~*~*~ Welcome to the Sample Calculator! *~*~*~*~\n\n");

// Prompt for User Input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\nPlease enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show Calculator Operations
Console.WriteLine("Here are your calculation choices:\n");
Console.WriteLine("Select '1' for addition...");
Console.WriteLine("Select '2' for subtraction...");
Console.WriteLine("Select '3' for multiplication...");
Console.WriteLine("Select '4' for division...");
Console.Write("\nWhat calculation would you like to make: ");
int calculation = Convert.ToInt32(Console.ReadLine());

// Decide Which Operations are Needed Based On Selections
int result = 0;
string symbol = string.Empty;

if (calculation == 1)
{
    result = num1 + num2;
    symbol = "+";
} else if (calculation == 2)
{
    result = num1 - num2;
    symbol = "-";
} else if (calculation == 3)
{
    result = num1 * num2;
    symbol = "*";
} else if (calculation == 4)
{
    result = num1 / num2;
    symbol = "/";
} else
{
    symbol = "MISSING";
    Console.WriteLine("\nYou did not select a valid calculation.\n");
}

// Print Output
if (calculation >= 1 && calculation <= 4)
{
    Console.WriteLine($"\n{num1} {symbol} {num2} = {result}\n");
} else
{
    Console.WriteLine("Please try again.");
}


