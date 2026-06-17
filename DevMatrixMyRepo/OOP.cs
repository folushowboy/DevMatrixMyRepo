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
        public OOP(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static void OopLog()
        {
            Console.WriteLine("Name = {0}", Name);
        }
    }
}
