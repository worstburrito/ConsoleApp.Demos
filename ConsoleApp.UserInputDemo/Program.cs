// declare variables - name and age
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retireAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working;



// prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

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
Console.WriteLine($"\nFull name: {firstName} {lastName}\nAge: {age}\nSalary: {salary:C}\nGender: {gender}\nCurrently employed: {working}\nWorking years remaining: {yearsToRetire}");

