using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class CalculatorProject
    {
        public void Add()
        {
            Console.Write("How many numbers do you want to add? ");

            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.Write("Invalid input. Enter only numbers: ");
                continue;
            }

            double sum = 0;

            for (int i = 1; i <= count; i++)
            {
                double number;

                Console.Write($"Enter number {i}: ");

                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Invalid input. Enter a valid number: ");
                    continue;
                }

                sum += number;
            }

            Console.WriteLine($"\nThe sum is: {sum}");

        }

        public static void Subtract()
        {
            Console.Write("How many numbers do you want to subtract? ");

            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.Write("Invalid input. Enter only numbers: ");
                continue;
            }

            Console.Write("Enter number 1: ");
            double subtract;
            while (!double.TryParse(Console.ReadLine(), out subtract))
            {
                Console.Write("Invalid input. Enter a valid number: ");
                continue;
            }

            for (int i = 2; i <= count; i++)
            {
                double number;

                Console.Write($"Enter number {i}: ");

                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Invalid input. Enter a valid number: ");
                    continue;
                }

                subtract -= number;
            }

            Console.WriteLine($"\nThe subtraction is: {subtract}");
        }

        public static void Multiply()
        {
            Console.Write("How many numbers do you want to multiply? ");

            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.Write("Invalid input. Enter only numbers: ");
                continue;
            }

            double multiply = 1;

            for (int i = 1; i <= count; i++)
            {
                double number;

                Console.Write($"Enter number {i}: ");

                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Invalid input. Enter a valid number: ");
                    continue;
                }

                multiply *= number;
            }

            Console.WriteLine($"\nThe multiplication is: {multiply}");
        }

        public void Divide()
        {
            Console.Write("How many numbers do you want to divide? ");

            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.Write("Invalid input. Enter only numbers: ");
                continue;
            }

            Console.Write("Enter number 1: ");
            double divide;
            while (!double.TryParse(Console.ReadLine(), out divide))
            {
                Console.Write("Invalid input. Enter a valid number: ");
                continue;
            }

            for (int i = 2; i <= count; i++)
            {
                double number;

                Console.Write($"Enter number {i}: ");

                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Invalid input. Enter a valid number: ");
                    continue;
                }

                if (number == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }

                divide /= number;
            }

            Console.WriteLine($"\nThe division is: {divide}");
        }

        public static void Percentage()
        {
            double number;
            double percent;

            Console.Write("Enter the number: ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Enter a valid number: ");
                continue;
            }

            Console.Write("Enter the percentage (%): ");
            while (!double.TryParse(Console.ReadLine(), out percent))
            {
                Console.Write("Invalid input. Enter a valid percentage: ");
                continue;
            }

            double result = (number * percent) / 100;

            Console.WriteLine($"\n{percent}% of {number} = {result}");
        }

        public static void Convertion()
        {
           
            while (true) 
            {
                Console.WriteLine("What currncy would like to convert to?");
                Console.WriteLine("1. USD -> EUR");
                Console.WriteLine("2. N -> USD");
                Console.WriteLine("3. USD -> GBP");
                Console.WriteLine("4. GBP -> N");
                Console.WriteLine("5. USD -> YEN");

                if (!int.TryParse(Console.ReadLine(), out var option))
                {
                    Console.WriteLine("Invalid Input. Enter a number between 1 and 5");
                    continue;
                }
                Console.WriteLine("Enter amount");
                var amount =double.Parse(Console.ReadLine());
                double result = 0;
                switch (option)
                {
                    case 1:
                        result = amount * 0.92;
                        Console.WriteLine($"{amount} USD = {result} EUR");
                        break;
                    case 2:
                        result = amount * 1.09;
                        Console.WriteLine($"{amount} N = {result} USD");
                        break;

                    case 3:
                        result = amount * 0.79;
                        Console.WriteLine($"{amount} USD = {result:F2} GBP");
                        break;

                    case 4:
                        result = amount * 1.27;
                        Console.WriteLine($"{amount} GBP = {result:F2} N");
                        break;
                    case 5:
                        result = amount * 1.27;
                        Console.WriteLine($"{amount} USD = {result:F2} YEN");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

           
        }

    }
}
