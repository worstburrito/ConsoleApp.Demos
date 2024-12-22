// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.CompilerServices;

/* Empty Date Time Object 

DateTime date = new DateTime();
*/

/* Create a DateTime From Date and Time

var dateOfBirth = new DateTime(1987, 12, 01);
Console.WriteLine($"My birthday is {dateOfBirth}");

var exactDateOfBirth = new DateTime(1987, 12, 01, 09, 15, 35);
Console.WriteLine($"My exact birthday is {exactDateOfBirth}");

Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {dateOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {exactDateOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateOfBirth.Kind}");
*/

/* Create a DateTime From Current Timestamp

DateTime now = DateTime.Now;
Console.WriteLine(now);
*/

/* Create a DateTime From a String 

Console.Write("What is your date of birth?: ");
string? dob = Console.ReadLine();

var userDob = DateTime.Parse(dob);
Console.WriteLine($"Your date of birth is: {userDob}");
*/



/* Change Format DateTime 
 * 
DateTime formatDate = DateTime.Now;
Console.WriteLine($"\n\nFormatted Date: {formatDate.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {formatDate.ToString("MM, dd-yyyy")}");
Console.WriteLine($"Formatted Date: {formatDate.ToString("dd-MMM-yyyy")}");
Console.WriteLine($"Formatted Date: {formatDate.ToString("dddd-MMMM-yyyy\n\n")}");
*/

/* Add Additional Time 

Console.WriteLine($"One hour from now is: {now.AddHours(1)}");
Console.WriteLine($"One day from now is: {now.AddDays(1)}");
Console.WriteLine($"One day ago from now is: {now.AddDays(-1)}");
*/




/* UTC 

DateTime now = DateTime.Now;
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Now Date Time: {now}");
Console.WriteLine($"Now Date Time: {utcNow}\n\n");
*/

/* DateTimeOffSet and TimeZone Info 

var tz = TimeZoneInfo.Local.GetUtcOffset( utcNow );
Console.WriteLine($"User Time Zone: {tz}\n\n");


var dto = new DateTimeOffset(now, tz);
Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}\n\n");

var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);

Console.WriteLine($"Action was completed in India at: {indiaDateTime}");
*/

/* Date Only 

var dateOnly = new DateOnly(1987,12,01);
Console.WriteLine($"Date Only: {dateOnly} \n\n");

Console.Write($"What is your date of birth? (dd MMM yyyy): ");
string? dobDateOnly = Console.ReadLine();

var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);

Console.WriteLine($"\n\nThe Date Only: {theDateOnly}");
*/

/* Time Only 

var timeNow = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"Time Only: {timeNow}");
*/

/* Date Comparisons 

var date1 = new DateTime(1985, 11, 23);
var date2 = new DateTime(1965, 1, 20);

Console.WriteLine($"Is '{nameof(date1)}' equal? {date1 == date2}");
Console.WriteLine($"Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
Console.WriteLine($"Is {date2} after? {date2 > date1}");
Console.WriteLine($"Is {date2} before? {date2 < date1}");
*/


