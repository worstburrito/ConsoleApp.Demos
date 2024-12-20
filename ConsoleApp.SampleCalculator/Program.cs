// See https://aka.ms/new-console-template for more information

// Weclome Message
Console.WriteLine("*~*~*~*~ Welcome to the Sample Calculator! *~*~*~*~\n\n");
Console.WriteLine("\nWould you like to get started? Press 'Enter' continue or 'E' to exit calculator: ");

// Initialize all variables to be in a global scope
string? choice = Console.ReadLine();
int calculation = 0;
int num1 = 0;
int num2 = 0;


while (choice != "E")
{
    try
    {
        // Show Calculator Operations
        Console.WriteLine("Here are your calculation choices:\n");
        Console.WriteLine("Select '1' for addition...");
        Console.WriteLine("Select '2' for subtraction...");
        Console.WriteLine("Select '3' for multiplication...");
        Console.WriteLine("Select '4' for division...");
        Console.WriteLine("Select '5' for Fibonacci sequence...");
        Console.Write("\nWhat calculation would you like to make: ");
        calculation = Convert.ToInt32(Console.ReadLine());

        if (calculation >=1 && calculation <=5)
        {
            // Prompt for User Input
            Console.Write("\nPlease enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        } else
        {
            Console.WriteLine("\nInvalid input, press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            continue;
        }

        // Decide Which Operations are Needed Based On Selections
        int result = 0;
        string symbol = string.Empty;

        if (calculation == 1)
        {
            result = num1 + num2;
            symbol = "+";
        }
        else if (calculation == 2)
        {
            result = num1 - num2;
            symbol = "-";
        }
        else if (calculation == 3)
        {
            result = num1 * num2;
            symbol = "*";
        }
        else if (calculation == 4)
        {
            result = num1 / num2;
            symbol = "/";
        }
        else if (calculation == 5)
        {
            for (int i = num1; i <= num2; i++)
            {
                result += i;
            }
        }

        // Print Output Decisions
        if (calculation >= 1 && calculation <= 4)
        {
            Console.WriteLine($"\n{num1} {symbol} {num2} = {result}\n");
        }
        else if (calculation == 5)
        {
            Console.WriteLine($"\nFibonacci result: {result}\n");
        }
        else
        {
            Console.WriteLine("\nPlease try again.");
        }

        Console.WriteLine("\nWould you like to continue? Press 'Enter' continue or 'E' to exit calculator: ");
        choice = Console.ReadLine();
        Console.Clear();
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("\nCannot divide by zero.");
        continue;
    }
    catch (Exception)
    {
        Console.WriteLine("\nInvalid input, press 'Enter' to try again.");
        continue;
    } 
    finally
    {
        Console.WriteLine("\nPress 'Enter' to try again.");
        Console.ReadLine();
        Console.Clear();
    }
}

Console.WriteLine("\n\n*~*~*~*~ THANK YOU for using the Sample Calculator! *~*~*~*~\n\n");




