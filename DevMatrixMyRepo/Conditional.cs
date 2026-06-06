using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Conditional
    {
        public void ConditionalIf()
        {
            // If statement
            int age = 48;
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to driver license");
            }
            else
            {
                Console.WriteLine("You are not eligible to driver license");
            }
        }

        public static void ConditionalSwitch()
        {

            // switch statement

            int days = 6;

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
                    Console.WriteLine("Sunday");
                    break;
            }

            string months = "January";

            switch (months)
            {
                case "January":
                    Console.WriteLine("Capricorn Zodiac sign");
                    break;
                case "Febraury":
                    Console.WriteLine("Aquarius Zodiac sign");
                    break;
                case "March":
                    Console.WriteLine("Pisces Zodiac sign");
                    break;
                case "April":
                    Console.WriteLine("Aries Zodiac sign");
                    break;
                case "May":
                    Console.WriteLine("Taurus Zodiac sign");
                    break;
                case "June":
                    Console.WriteLine("Gemini Zodiac sign");
                    break;
                case "July":
                    Console.WriteLine("Cancer Zodiac sign");
                    break;
            }

        }

        public void SaleApp()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Cofee shope. Please make your order");
                Console.WriteLine(" 1. BlackCoffee = #500");
                Console.WriteLine(" 2. Tea = #1500");
                Console.WriteLine(" 3. CreamyCoffee = #700");
                Console.WriteLine(" 4. Expresso = #2000");
                Console.WriteLine(" 5. Cappuccino = #3500");
                Console.WriteLine(" 6. Americano = #1350");
                Console.WriteLine(" 7. Latte = #2105");

                int userChoice = int.Parse(Console.ReadLine());
                string coffeeName = "";
                int price = 0;


                switch (userChoice)
                {
                    case 1:
                        coffeeName = "BlackCoffee";
                        price = 500;
                        break;
                    case 2:
                        coffeeName = "Tea";
                        price = 1500;
                        break;
                    case 3:
                        coffeeName = "CreamyCoffee";
                        price = 700;
                        break;
                    case 4:
                        coffeeName = "Expresso";
                        price = 2000;
                        break;
                    case 5:
                        coffeeName = "Cappuccino";
                        price = 3500;
                        break;
                    case 6:
                        coffeeName = "Americano";
                        price = 1350;
                        break;
                    case 7:
                        coffeeName = "Latte";
                        price = 2105;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        continue;
                }


                Console.WriteLine($"Your order is {coffeeName}. How many {coffeeName} do you want? ");

                int quantity = int.Parse(Console.ReadLine());
                int total = quantity * price;

                //Receipt
                Console.WriteLine("Coffee Name: {0}", coffeeName);
                Console.WriteLine("Price: {0}", price);
                Console.WriteLine("Quantity: {0}", quantity);
                Console.WriteLine("Total: {0}", total);
                break;
            }
        }
    }
}
