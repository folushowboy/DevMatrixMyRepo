using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class CalculatorProject
    {
        public void Add(int x, int y, int z)
        {
            Console.WriteLine("Enter two number to Add");
            int result = x + y + z;
            Console.WriteLine(result);
        }

        public static int Subtract(int x, int y, int z)
        {
            int ans = x - y - z;
            return ans;
        }

        public static double Multiply(double x, double y, double z)
        {
            double result = x * y * z;
            return result;
        }

        public long Divide(long x, long y, long z)
        {
            long ans = x / y / z;
            return ans;
        }

        public static void Convertion()
        {
            var rate = 1500;
            Console.WriteLine("What currncy would like to convert to?");
            Console.WriteLine("1. USD -> EUR");
            Console.WriteLine("2. N -> USD");
            Console.WriteLine("3. USD -> GBP");
            Console.WriteLine("4. GBP -> N");
            Console.WriteLine("1. USD -> YEN");      
            
            while (true) 
            {
                if (!int.TryParse(Console.ReadLine(), out var option))
                {
                    Console.WriteLine("Invalid Input. Enter a number between 1 and 5");
                    continue;
                }else if (!double.TryParse(Console.ReadLine(), out var amount))
                {
                    Console.WriteLine("Invalid Input. Enter a number between 1 and 5");
                    continue;
                }
                var result = 0;
                switch (option)
                {
                    case 1:
                        result = 1 * rate;
                        break;
                }
            }

           
        }

    }
}
