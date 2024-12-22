// See https://aka.ms/new-console-template for more information
Console.WriteLine("******** - STRING MANIPULATION -********");

// Initialize with a regular string literal
string s1 = "This is a literal string. ";
String s2 = "This is a literal string.";

// Delcare without intialization (possible null exception)
string s3;

// Intialize to null
string? s4 = null;

// Initialize empty string
string s5 = string.Empty;
string s6 = "";

// Escape sequences and characters
string sentence = "She said, \"I have your phone\"";

// Verbatim string literal
string oldPath = "C:\\program files\\programfolder\\";
string newPath = @"C:\program files\programfolder\";

// Use a const string to prevent modication to a string
const string path = "C:\\program files\\programfolder\\";

// Raw string literals
string rawLiteral = """ \asda "this is a literal string" """;

// Review concatenation and interpolation
s1 += s2;
string newString = $"{s1} {s2} and some random literal text";
string newString1 = s1 + $"{s2} and some random literal text";
string newString2 = String.Format(rawLiteral, newString);

// String Manipulation Methods and Properties

// Null or empty checks
/*
Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");



if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}

if (string.IsNullOrEmpty(s5) == false)
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");

}
*/

// Substrings
/*
string subString = s1.Substring(0,4);
Console.WriteLine(s1);
Console.WriteLine(subString);
*/

// Splitting Strings
var stringToSplit = $"this-is-my-string-to-split\n";
Console.WriteLine(stringToSplit);

var splitStrings = stringToSplit.Split('-');
for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine(splitStrings[i]);
}

// Replace
string replacements = stringToSplit.Replace('-', ' ');
Console.WriteLine($"\n{replacements}");

// Convert to String
string salaryString = "140000";
int salaryInt = 140000;
string strValue = salaryInt.ToString();
Console.WriteLine($"{salaryString} | {salaryInt} | {strValue}");

// Changing Formatting
Console.WriteLine($"{nameof(salaryInt)} : {salaryInt:C}");