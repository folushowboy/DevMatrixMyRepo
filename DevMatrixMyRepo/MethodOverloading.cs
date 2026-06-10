using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    //Method Overloading
    //Method Overidding
    internal class MethodOverloading
    {
        public virtual void GetStudent()
        {
            Console.WriteLine("This is a student class");
        }
        public int GetStudent(int v)
        {
            return 90;
        }
        public string GetStudent(string x, int z)
        {
            return "Name";
        }
    }
}
