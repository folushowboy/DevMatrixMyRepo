using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DevMatrixMyRepo
{
    internal class StudentsDetails
    {
        string FirstName;
        string LastName;
        int Age;
        string Department;
        string Level;




        public StudentsDetails(string fname, string lname, int age, string dept, string lvl)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
            Department = dept;
            Level = lvl;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"The students first name is {FirstName}");
            Console.WriteLine("The students last name is " + LastName);
            Console.WriteLine("The students age is {0}", Age);
            Console.WriteLine($"The students department is {Department}");
            Console.WriteLine($"The students level is {Level}");
        }


    }
}
