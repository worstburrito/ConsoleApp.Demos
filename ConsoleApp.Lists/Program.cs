Console.WriteLine($"******** LISTS ********\n");

// Delare a List

//List<int> grades = new List<int>();
//List<int> grades = new();

var grades = new List<int>();
var students = new List<string>();

int grade = 0;
string name;
int quit;
int gradeCount = 0;

// Add Values to List

do
{
    gradeCount += 1;
    Console.Write("\nEnter Student Name: ");
    name = Console.ReadLine();
    students.Add(name);

    Console.Write("\nEnter Grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    grades.Add(grade);

    Console.Write("\nDo you wish to continue? (1 = y, 2 = n): ");
    quit = Convert.ToInt32(Console.ReadLine());

} while (quit == 1);

// Print Values In List - FOR
Console.WriteLine("\nThe grades you have entered are: \n");
for (int i = 0; i < gradeCount; i++)
{
    Console.WriteLine($"Student: {students[i]}, Grade: {grades[i]}");
}

//// Print Values In List - FOREACH
//Console.WriteLine("\nPrinting grades FOREACH LOOP: \n");

//foreach (int g in grades)
//{
//    Console.WriteLine(g);
//}