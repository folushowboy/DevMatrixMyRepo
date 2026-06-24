using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public delegate bool SampleDelegate(DelegateSamples1 students);
    public class DelegateSamples1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        
       public static void DisplayStudentInfo(List<DelegateSamples1> students, SampleDelegate checkLogic)
        {
            foreach(DelegateSamples1 std in students)
            {
                if(checkLogic(std))
                {
                    std.Level += 100;
                    Console.WriteLine($"{std.Name} has been promoted to {std.Level} level.");
                }
            }
        }

    }
















































    //public delegate void FunctionPointer();
    //public delegate void FunctionPointer2(string x);

    //public class DelegateSamples1
    //{
    //    public static void MySmapleMethod()
    //    {
    //        Console.WriteLine("Hello from MySmapleMethod");
    //    }
    //}
    //public class DelegateSamples2
    //{
    //    public static void MyDelegateMethod()
    //    {
    //        Console.WriteLine("Hello from DelegateMethod");
    //    }

    //    public static void MyDelegateMethod2(string x)
    //    {
    //        if (string.IsNullOrEmpty(x)) //Null Collation
    //        {
    //            x = "Welcome to the second month of the class";

    //        }
    //        Console.WriteLine(x);
    //    }
    //}
}
