using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Conditionals
    {
        public static void ConditionalIfElse()
        {
            //IF ELSE
            int grade = 90;
            if(grade >= 70 && grade <= 100)
            {
                Console.WriteLine("A");
            }else if(grade >= 60 && grade <= 69)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 50 && grade <= 59)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 45 && grade <= 49)
            {
                Console.WriteLine("D");
            }
            else if (grade >= 40 && grade <= 44)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("F");
            }

            //Switch
            int days = 3;
            switch (days)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Monday");
                    break;
                default:
                    Console.WriteLine("Invalid days"); 
                    break;
            }
        }
    }
}
