// See https://aka.ms/new-console-template for more information

// Variable Declarations
int choice = 0;
int num1, num2 = 0;

// Show calculator options / Show menu
while (choice != -1)
{
    try
    {
        // Welcome Message
        PrintMenu();

        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        Console.Write("\nPlease enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nPlease enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        /* Switch statement */
        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = AddNumbers(num1, num2);
                break;
            case 2:
                answer = SubtractNumbers(num1, num2);
                break;
            case 3:
                answer = MultiplyNumbers(num1, num2);
                break;
            case 4:
                answer = DivideNumbers(num1, num2);
                break;
            case 5:
                answer = Fibonacci(num1, num2);
                break;
            default:
                throw new Exception("\nInvalid Menu Item Selected.");
        }

        // print output 
        Console.WriteLine($"\nThe result is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("\nCannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadLine();
    }
}

Console.WriteLine("\n******** - Thank you for using the sample calculator! - ********\n");




// Methods
void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("\n******** - Welcome to the sample calculator! - ********\n");
    Console.WriteLine("Please select an operation (-1 to exit program) ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
}

int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}

int MultiplyNumbers(int num1, int num2)
{
    return num1 * num2;
}

int DivideNumbers(int num1, int num2)
{
    return num1 / num2;
}

int Fibonacci(int num1, int num2)
{
    var answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }
    return answer;
}




