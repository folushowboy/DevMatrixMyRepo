using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Booleans
    {
        public static void BooleanString() 
        {
            string fullName = "Odusina Tolulope";
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName.ToLower());
            Console.WriteLine(fullName.Length);

            int age = 4;
            if(age >= 19)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }

        }
    }
}
