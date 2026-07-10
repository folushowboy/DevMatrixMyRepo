using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class StudentsDictionary
    {
        public static void StdsDictionary(Dictionary<int, string> Students)
        {
            Students.Add(120, "Odusina"); //Add students to the list
            Students.Remove(105); //Remove students
            //Find students
            foreach (var std in Students) //View all students in the list
            {
                Console.WriteLine($"{std.Key}. {std.Value}");
            }
            
        }
    }
}
