using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Operators
    {
        public static void OperatorsInfo()
        {
            //Arithmetic Operators: +, -, *, /, %
            int a = 10;
            int b = 3;
            Console.WriteLine(a + b); // 13
            Console.WriteLine(a - b); // 7
            Console.WriteLine(a * b); // 30
            Console.WriteLine(a / b); // 3
            Console.WriteLine(a % b); // 1
            //Comparison Operators: ==, !=, >, <, >=, <=
            Console.WriteLine(a == b); // false
            Console.WriteLine(a != b); // true
            Console.WriteLine(a > b); // true
            Console.WriteLine(a < b); // false
            Console.WriteLine(a >= b); // true
            Console.WriteLine(a <= b); // false
            //Logical Operators: &&, ||, !
            bool x = true;
            bool y = false;
            Console.WriteLine(x && y); // false
            Console.WriteLine(x || y); // true
            Console.WriteLine(!x); // false
            // Assignment Operators: =, +=, -=, *=, /=, %=
            Console.WriteLine(a += b); // 13
            Console.WriteLine(a -= b); // 10
            Console.WriteLine(a *= b); // 30
            Console.WriteLine(a /= b); // 10
            Console.WriteLine(a %= b); // 1
        }
    }
}
