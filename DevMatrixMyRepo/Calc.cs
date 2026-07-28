using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class Calc
    {
        //Build a calculator that adds, subtracts, divides, multiplies, percentage, and rate conversion  
        public static void Add()
        {
            Console.Write("How many numbers do you want to Add? ");
            int countValue;
            while(!int.TryParse(Console.ReadLine(), out countValue))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }

            double sum = 0;
           
            for(int i = 1; i <= countValue; i++)
            {
                Console.Write("Enter number {0}: ", i);
                double number;
                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input, Enter numbers only.");
                }
                sum += number;
            }
            Console.WriteLine($"\nThe sum = {sum}");
        }

        public static void Subtract()
        {
            Console.Write("How many numbers do you want to Substract? ");
            int countValue;
            while(!int.TryParse(Console.ReadLine(), out countValue))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }

            double subtract;
            Console.Write("Enter number 1: ");
            while(!double.TryParse(Console.ReadLine(), out subtract))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }

            for (int i = 2; i <= countValue; i++)
            {
                Console.Write("Enter number {0}: ", i);
                double number;
                while(!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input, Enter numbers only.");
                }
                subtract -= number;
            }
            Console.WriteLine($"\nThe Subtraction = {subtract}");
        }

        public static void Multiply()
        {
            Console.Write("How many numbers do you want to Multiply? ");
            int countValue;
            while (!int.TryParse(Console.ReadLine(), out countValue))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }

            double multiply = 1;

            for(int i = 1; i <= countValue; i++)
            {
                Console.Write($"Enter number {i}: ");
                double number;
                while(!double.TryParse(Console.ReadLine(),out number))
                {
                    Console.WriteLine("Invalid input, Enter numbers only.");
                }
                multiply *= number;
            }
            Console.WriteLine($"\nThe Multiplication = {multiply}");
        }

        public static void Divide()
        {
            Console.Write("How many numbers do you want to Divide? ");
            int countValue;
            while(!int.TryParse(Console.ReadLine(), out countValue))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }

            Console.Write($"Enter number 1: ");
            double divide;
            while(!double.TryParse(Console.ReadLine(), out divide))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }

            for ( int i = 2; i <= countValue; i++)
            {
                Console.Write($"Enter number {i}: ");
                double number;
                while(!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input, Enter numbers only.");
                }
                divide /= number;
            }
            Console.WriteLine($"\nThe Division = {divide}");
        }

        public static void Percentage()
        {
            double number;
            int percent;

            Console.Write("Enter number? ");
            while(!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }

            Console.Write("Enter the percentage (%): ");
            while (!int.TryParse(Console.ReadLine(), out percent))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }

            var result = (number / percent * 100);
            Console.WriteLine($"\n{percent}% of {number} = {result}");
        }

        public static void Conversion()
        {
            Console.WriteLine("What currncy would like to convert to?");
            Console.WriteLine("1. USD -> EUR");
            Console.WriteLine("2. N -> USD");
            Console.WriteLine("3. USD -> GBP");
            Console.WriteLine("4. GBP -> N");
            Console.WriteLine("5. USD -> YEN");

            int choice;
            double amount;
           
            while(!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }

            Console.WriteLine("Enter amount to convert?");
            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid input, Enter numbers only.");
            }
            switch (choice)
            {
                case 1 :
                    var USDEUR = amount * 0.86;
                    Console.WriteLine($"{amount} USD = {USDEUR} EUR");
                    break;
                case 2:
                    var NUSD = amount / 1650;
                    Console.WriteLine($"{amount} N = {NUSD} USD");
                    break;
                case 3:
                    var USDGBP = amount * 0.75;
                    Console.WriteLine($"{amount} N = {USDGBP} USD");
                    break;
                case 4:
                    var GBPN = amount * 2200;
                    Console.WriteLine($"{amount} N = {GBPN} USD");
                    break;
                case 5:
                    var USDYEN = amount * 150;
                    Console.WriteLine($"{amount} N = {USDYEN} USD");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
