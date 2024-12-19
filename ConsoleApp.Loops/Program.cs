// See https://aka.ms/new-console-template for more information

// Simple For Loop Demo
// Print Hello World 10 Times

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello World - {i}");
}
*/

// Ask the User How Many Times to Print Hello World
/*
Console.Write("\nHow many times would you like to print 'Hello World'?: \n");
int count = Convert.ToInt32( Console.ReadLine() );

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Hello World - {i}");
}
*/

// Simple While Loop Demo
/*
using System.Diagnostics.Metrics;

int count = 0;
while (count < 10)
{
    Console.WriteLine($"Hello World! -> {count}");
    count += 2;
}
*/

// While Loop Challenge
/*
int sum = 0;
int num = 0;


while (num != -1)
{
    Console.WriteLine("Please enter numbers to be summed up. (-1 to stop loop)");
    num = Convert.ToInt32(Console.ReadLine());

    if (num != -1)
    {
        sum += num;
    }
}
Console.WriteLine($"Sum: {sum}");
*/

// Do While Loops Demo
/*
int sum = 0;
int num = 0;

do
{
    Console.WriteLine("Please enter numbers to be summed up. (-1 to stop loop)");
    num = Convert.ToInt32(Console.ReadLine());

    if (num != -1)
    {
        sum += num;
    }
} while (num != -1);
Console.WriteLine($"Sum: {sum}");
*/