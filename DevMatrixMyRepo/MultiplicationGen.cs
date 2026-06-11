using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DevMatrixMyRepo
{
    internal class MultiplicationGen
    {
        public void MultiplyGen()
        {
            int number;
            string choice = "YES";
            while (choice == "YES")
            {
                Console.WriteLine("Enter a number.");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                    continue;
                }
                MultiplyGenerate(number);

                Console.WriteLine("\nGenerate new table? YES/NO");
                choice = Console.ReadLine().ToUpper();

            }

        } 
        public void MultiplyGenerate(int number)
        {
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
         
        }
    }
}
