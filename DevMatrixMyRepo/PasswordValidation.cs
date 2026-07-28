using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class PasswordValidation
    {
        public static void Password()
        {
            while (true)
            {
                Console.WriteLine("Enter your password? ");
                string password = Console.ReadLine();
                if (PaswordValid(password))
                {
                    Console.WriteLine("Correct Password.");
                    break;
                }
                else
                {
                    Console.WriteLine("Ivalid password.");
                    Console.WriteLine("Password must contain at least a 8 digit .");
                    Console.WriteLine("Password must contain at least a number .");
                    Console.WriteLine("Password must contain at least an uppercase .");
                }
            }
        }

        public static bool PaswordValid(string password)
        {
            bool isNumber = false;
            bool isupper = false;
            if (password.Length < 8)
            {
                return false;
            }
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    isNumber = true;
                }
                else if (char.IsUpper(c))
                {
                    isupper = true;
                }
            }
            return isNumber && isupper;
        }
    }
}
