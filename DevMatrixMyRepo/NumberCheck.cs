using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class NumberCheck
    {
        public void PhoneNumberCheck()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Enter your Phone number");
                if(!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input. Enter numbers");
                    continue;
                }else if(number < 11)
                {
                    Console.WriteLine("Your number is not complete. 10 digits");
                    continue;
                }
            }
            PhoneNumberCheck2(number);
        }

        public void PhoneNumberCheck2(int number) 
        {
            foreach(int c in number)
            {
                if(c >= 7 && number <= 11)
                {
                    Console.WriteLine("****");
                }
            }
        }
    }
}
