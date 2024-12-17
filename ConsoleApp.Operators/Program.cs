// Input Requests
Console.Write("Please enter the first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());


// Math Operations
int sum = firstNum + secondNum;
int product = firstNum * secondNum;
int quotient = firstNum / secondNum;
int difference = firstNum - secondNum;
int mod = firstNum % secondNum;

Console.WriteLine($"\n********** MATH OPERATIONS **********\n");

// Math Operations Output
Console.WriteLine($"Sum of those two numbers: {sum}");
Console.WriteLine($"Product of those two numbers: {product}");
Console.WriteLine($"Quotient of those two numbers: {quotient}");
Console.WriteLine($"Difference of those two numbers: {difference}");
Console.WriteLine($"Modulus of those two numbers: {mod}");

// Logic Operations and Operators
var isGreaterThan = firstNum > secondNum;
var isLessThan = firstNum < secondNum;
var isEqualTo = firstNum == secondNum;
var isGreaterThanOrEqualTo = firstNum >= secondNum;
var isLessThanOrEqualTo = firstNum <= secondNum;
var isNotEqual = firstNum != secondNum;

Console.WriteLine($"\n********** LOGICAL OPERATIONS **********\n");

// Logic Operations and Operators Output
Console.WriteLine($"Is the first number greater than the second number? {isGreaterThan}");
Console.WriteLine($"Is the first number less than the second number? {isLessThan}");
Console.WriteLine($"Are they the same number? {isEqualTo}");
Console.WriteLine($"Is the first number greater than or equal to the second? {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is the first number less than or equal to the second? {isLessThanOrEqualTo}");
Console.WriteLine($"Are they two different numbers? {isNotEqual}");

// Assignment Operations and Operators

Console.WriteLine($"\n********** ASSIGNMENT RESULTS **********\n");
firstNum += 5;
Console.WriteLine($"First number increased by 5: {firstNum}\n");

firstNum -= 3;
Console.WriteLine($"First number decreased by 3: {firstNum}\n");

firstNum /= 2;
Console.WriteLine($"First number divided by 2: {firstNum}\n");

firstNum %= 2;
Console.WriteLine($"First number modulus 2: {firstNum}\n");

firstNum *= 10;
Console.WriteLine($"First number multipled by 10: {firstNum}\n");

