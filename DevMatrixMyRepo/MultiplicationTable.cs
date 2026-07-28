using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class MultiplicationTable
    {
        public static void Table()
        {
            Console.WriteLine("Enter number");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Must be numbers.");
            }

            for(int i = 1; i <= 20; i++)
            {
               Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
