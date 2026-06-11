using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class MultiplicationGen
    {
        int myValue;
        public void MultiplyGen(int x)
        {
            if(!int.TryParse(Console.ReadLine(), out myValue))
            {
                Console.WriteLine("Invalid input. Enter a number.");
            }
        }
    }
}
