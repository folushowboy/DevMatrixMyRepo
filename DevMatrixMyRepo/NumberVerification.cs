using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class NumberVerification
    {

        public void VerifyNumber()
        {
            while (true)
            {
                Console.WriteLine("Enter your 11 digits number");
                string number = Console.ReadLine();

                if(number.Length > 11)
                {
                    Console.WriteLine("The number is too long. 11 digits");
                    continue;
                }else if(number.Length < 11)
                {
                    Console.WriteLine("The number is too short. 11 digits");
                    continue;
                }
                VerifyNum(number);
                break;
            }
           
        }

        public void VerifyNum(string number)
        {
            for(int i = 0; i <= number.Length; i++)
            {
                if(i > 7)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine(number[i]);
                }
            }
        }





































        //public void VerifyNumber() {

        //    while (true)
        //    {
        //        Console.WriteLine("Enter your 11 digits Phone Number");
        //        string number = Console.ReadLine();

        //        if (number.Length > 11)
        //        {
        //            Console.WriteLine("Too much");
        //            continue;
        //        }else if(number.Length < 11)
        //        {
        //            Console.WriteLine("Too short");
        //            continue;
        //        }
        //        VerifyNum(number);
        //        break;
        //    }

        //}

        //public void VerifyNum(string number)
        //{

        //    for (int i = 0; i <= number.Length; i++)
        //    {
        //        if(i > 7)
        //        {
        //            Console.WriteLine("*");
        //        }
        //        else
        //        {
        //            Console.WriteLine(number[i]);
        //        }
        //    }


        //}
    }
}

