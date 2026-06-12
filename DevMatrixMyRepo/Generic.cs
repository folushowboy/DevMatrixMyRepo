using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class Generic<T>
    {
        public T value; 
        public static void ShowEachInfo(T info)
        {
            Console.WriteLine(info);
        }

        public static void DisplayInfo(T info1, T info2, T info3)
        {
            Console.WriteLine($"This info is for {info1}, {info2} and {info3}");
        }
    }
}
