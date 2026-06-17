using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class OOP
    {
        string Name;
        int Age;
        string StudentDept;
        string StudentLevel;
        string StudentUni;

        public OOP(string name, int age, string studentdept, string studentlvl, string studentuni)
        {
            Name = name;
            Age = age;
            StudentDept = studentdept;
            StudentLevel = studentlvl;
            StudentUni = studentuni;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Name = {0}", Name);
            Console.WriteLine("Age = {0}", Age);
            Console.WriteLine("Dept = {0}", StudentDept);
            Console.WriteLine($"Level = {StudentLevel}");
            Console.WriteLine($"University = {StudentUni}");

        }
    }
}


