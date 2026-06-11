using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class MultiplicationGen
    {
        public void MultiplyGen()
        {
            int number = int.Parse(Console.ReadLine());
            MultiplyGenerate(number);
        } 
        public void MultiplyGenerate(int number)
        {
           for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
          
        }
    }
}
