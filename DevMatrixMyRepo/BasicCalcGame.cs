using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class BasicCalcGame
    {
        public void Add(int x, int y, int z)
        {
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
            long ans = x / y / z ;
            return ans;
        }
    }
}
