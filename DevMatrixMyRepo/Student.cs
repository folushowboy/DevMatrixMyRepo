using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }

        public static void DisplayStudents(Queue<Student> student)
        {
            foreach(Student item in student)
            {
                Console.WriteLine(item.StudentName);
            }
        }

        public static void DisplayStudentsgreaterthan18(Queue<Student> student)
        {
            foreach(Student item in student)
            {
                if (item.StudentAge >= 18)
                {
                    Console.WriteLine(item.StudentName);
                }
            }
           
        }



    }
}
