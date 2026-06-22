using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public delegate void FunctionPointer();
    public delegate void FunctionPointer2(string x);

    public class DelegateSamples1
    {
        public static void MySmapleMethod()
        {
            Console.WriteLine("Hello from MySmapleMethod");
        }
    }
    public class DelegateSamples2
    {
        public static void MyDelegateMethod()
        {
            Console.WriteLine("Hello from DelegateMethod");
        }

        public static void MyDelegateMethod2(string x)
        {
            if (string.IsNullOrEmpty(x)) //Null Collation
            {
                x = "Welcome to the second month of the class";

            }
            Console.WriteLine(x);
        }
    }
}
