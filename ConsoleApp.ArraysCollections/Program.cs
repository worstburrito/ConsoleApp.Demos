using System.ComponentModel.DataAnnotations;

Console.WriteLine($"******** ARRAYS ********\n");


/* Declare Fixed Size Array */

Console.Write($"How many grades are you entering? ");
int numOfGrades = Convert.ToInt32( Console.ReadLine() );

int[] grades = new int[numOfGrades];
string[] names = new string[numOfGrades];

/* Add Values to Fixed Size Array */

//grades[0] = 45;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

for (int i = 0; i < numOfGrades; i++)
{
    Console.Write("\nEnter Student Name: ");
    names[i] = Console.ReadLine();

    Console.Write("\nEnter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

/* Print Values in Fixed Size Array */
Console.WriteLine("\nThe grades you have entered are: \n");
for (int i = 0; i < numOfGrades; i++)
{
    Console.WriteLine($"Student: {names[i]}, Grade: {grades[i]}");
}







///* Declare Variable Sized Array */
//string[] studentNames = new string[] { "John", "Mary", "Edgar", "Susan", "Emmett", "Darla" };



///* Add Values to Variable Sized Array */

//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.Write("\nEnter Student Name: ");
//    studentNames[i] = Console.ReadLine();
//}

///* Print Values to Variable Sized Array */
//Console.WriteLine("\nThe names you have entered are: \n");
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine($"{studentNames[i]}");
//}