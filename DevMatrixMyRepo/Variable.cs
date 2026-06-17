using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Variable
    {
        public static void VariableDataTypes()
        {
            //Variable, Datatypes, User input
            string name = "Timi";
            int age = 64;
            string country = "Nigeria";
            bool isHungry = true;
            double dec = 1.233;
            decimal names = 143.33m;
            float Number = 22.344f;
            char character = 'A';

            Console.WriteLine($"My name is {name}, you are {age} years old");

            //Operators
            int add = 20 + 10;
            int subtract = 20 - 10;
            int multiply = 20 * 10;
            int divide = 20 / 10;

            Console.WriteLine(add);
            Console.WriteLine(subtract);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);


        }
    }
}
