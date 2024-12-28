using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes
{
    public class Student : Person
    {
        public void GenerateStudentIdNumber()
        {
            _idNumber = "STU-" + GetRandomNumber();
        }
    }
}
