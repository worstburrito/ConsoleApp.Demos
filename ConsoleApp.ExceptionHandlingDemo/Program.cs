// See https://aka.ms/new-console-template for more information

// Write a program that takes a user's age as input and prints it to the screen. Display an error message if an invalid input is recieved.

try
{
    Console.Write("Please enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"\nYou are {age} years old.");
}
catch (Exception)
{
    Console.WriteLine("\nYour age value was invalid. Please try again!");
    // throw;
}
finally
{
    Console.WriteLine("\n ~*~*~*~*~* Thank you for using our program! ~*~*~*~*~*");
}





