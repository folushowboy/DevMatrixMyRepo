using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Loops
    {
        public static void Loopings()
        {
            //While loop
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //For
            int num = 5;
            for(i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

            //Break and Continue

        }
    }
}
