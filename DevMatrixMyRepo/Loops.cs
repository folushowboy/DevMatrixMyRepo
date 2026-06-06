using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Loops
    {
        public void LoopsInfo()
        {
            // For Loop
            // While Loop
            // Do-While Loop
            // Foreach Loop

            //Foreach Loop

            int[] wholeNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int x in wholeNumbers)
            {
                Console.WriteLine(x);
            }

            double[] numbers = new double[5];
            numbers[0] = 11.3;
            numbers[1] = 12.5;
            numbers[2] = 13.7;
            numbers[3] = 14.9;
            numbers[4] = 15.1;

            foreach (double num in numbers)
            {
                Console.WriteLine(num);
            }

            // //for loop
            for (int x = 0; x <= 50; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }

            //while loop
            int y = 0;
            while (y <= 30)
            {
                if (y % 2 != 0)
                {
                    Console.WriteLine(y);
                }
                y++;
            }

            //do-while loop

            int z = 0;
            do
            {
                if (z % 2 == 0)
                {
                    Console.WriteLine(z);
                }
                z++;
            } while (z <= 20);
        }
    }
}
