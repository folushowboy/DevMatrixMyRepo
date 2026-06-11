using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class PasswordValidation
    {
        public void PasswordValid()
        {
            string password;

            while (true)
            {
                Console.WriteLine("Enter your password");
                password = Console.ReadLine();
                if (ValidationPass(password))
                {
                    Console.WriteLine("Password is valid");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Password. Try again!");
                    Console.WriteLine("Password must contain atleast 8 characters.");
                    Console.WriteLine("Password must contain atleast uppercase character.");
                    Console.WriteLine("Password must contain atleast a number!");

                }
            }

        }

        public bool ValidationPass(string password)
        {
            bool isNumber = false;
            bool isUppercase = false;

            if(password.Length < 8)
            {
                return false;
            }
            foreach(char c in password)
            {
                if (char.IsUpper(c))
                {
                    isUppercase = true;
                }else if (char.IsDigit(c))
                {
                    isNumber = true;
                }
            }
            return isNumber && isUppercase;

        }
    }
          
}
