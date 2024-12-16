// declare variables - name and age
string name = string.Empty;
int age = 0;
int retireAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working;



// prompt the user for input
Console.Write("Please enter your name: ");
name = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender as 'M', 'F', or 'O' (for other): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you currently employed? 'true' or 'false': ");
working = Convert.ToBoolean(Console.ReadLine());



// find retirement years left
int yearsToRetire = retireAge - age;



// output the results
Console.WriteLine($"\nFull name: {name}\nAge: {age}\nWorking years remaining: {yearsToRetire}\nSalary: {salary:C}\nGender: {gender}\nCurrently employed: {working}");

