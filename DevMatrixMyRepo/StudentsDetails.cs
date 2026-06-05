using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class StudentsDetails
    {
        string FirstName;
        string LastName;
        int Age;
        string Department;
        string Level;

        public StudentsDetails(string fName, string lName, int age, string dept, string level)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            Department = dept;
            Level = level;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"The students First Name: {FirstName}");
            Console.WriteLine($"The students Last Name: {LastName}");
            Console.WriteLine($"The students Age: {Age} years old");
            Console.WriteLine($"The students Department: {Department}");
            Console.WriteLine($"The students Level: {Level} Level");
        }
    }
}
