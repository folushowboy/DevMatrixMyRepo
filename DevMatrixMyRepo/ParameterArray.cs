using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class ParameterArray
    {
        public static void SimpleArrParameter(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);
            foreach (int x in Numbers)
            {
                Console.WriteLine(x);
            }
    }   }
       
}
