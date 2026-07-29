using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class PhoneNumberVerification
    {
        public static void PhoneNumber()
        {
            Console.WriteLine("Enter your 11 digit Phone number?");
            while(true)
            {
                string phoneNum = Console.ReadLine();
                if (string.IsNullOrEmpty(phoneNum))
                {
                    Console.WriteLine("Invalid input. Enter number only");
                    continue;
                }
                else if(phoneNum.Length < 11)
                {
                    Console.WriteLine("Phone number too low. Number must be 11 ");
                    continue;
                }
                else if(phoneNum.Length > 11)
                {
                    Console.WriteLine("Phone number too high. Number must be 11 ");
                    continue;
                }
                Phone(phoneNum);
                break;
            }
        }

        public static void Phone(string phoneNum)
        {
            for (int i = 0; i <= phoneNum.Length; i++)
            {
                if(i > 7)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(phoneNum[i]);
                }
            }
        }
    }
}
