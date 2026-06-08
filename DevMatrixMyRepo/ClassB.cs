using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class ClassB : ClassA, IStudent
    {
        public string ValueMethod()
        {
            string x = "Hello";
            Console.WriteLine(x);
            return x;
        }
    }

    public class ClassC : ClassB 
    {
        public int figures()
        {
            int z = 5 + 5;
            Console.WriteLine(z);
            return z;
        }
      
    }

}
