using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class OutParameter
    {
        //public static void SimpleOutParameter(int a, int b, out int sum, out int product)
        //{
        //    sum = a + b; //30
        //    product = a * b; //200
        //}

        public static void paramSimp(int x, int y, int z, out int divide, out int multiply, out int modulus)
        {
            divide = x / y / z;
            multiply = x * y * z;
            modulus = x % y % z;
        }
    }
}
