using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class CoffeeApp
    {
        public void CoffeeGame()
        {
            Console.WriteLine("Welcome to Dev Coffee, what would you like to order");
            Console.WriteLine("select your order by picking the order number ");
            Console.WriteLine("1.BlackCoffee == 500.");
            Console.WriteLine("2.Tea == 1500.");
            Console.WriteLine("3.CreamCoffee == 600");
            Console.WriteLine("4.Expresso == 2000");
            Console.WriteLine("5.Cappuccino == 3500");
            Console.WriteLine("6. Bread == 500");

            //int userChoice = int.Parse(Console.ReadLine());
            string coffeeName = "";
            int price = 0;

            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    Console.WriteLine("Invalid input. Please go back to the available options.");
                    continue;
                }
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
                        coffeeName = "CreamCoffee";
                        price = 600;
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
                        coffeeName = "Bread";
                        price = 500;
                        break;
                    default:
                        Console.WriteLine("Please go back to the available options.");
                        break;
                }

                Console.WriteLine($"You chose {coffeeName}. How many {coffeeName} do you want?");
                //int quantity = int.Parse(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine() , out int quantity))
                {
                    Console.WriteLine("Invalid input. Please go back to the available options."); 
                    continue;
                }
                    int total = price * quantity;

                //Receipt
                Console.WriteLine($"Ohhh, you chose {quantity} {coffeeName}. This is your receipt");
                Console.WriteLine("");
                Console.WriteLine($"Coffee Name = {coffeeName}");
                Console.WriteLine("Coffe Price = {0}", price);
                Console.WriteLine("Coffe Quantity = " + quantity);
                Console.WriteLine($"Total = {total}");
                break;
            }
        }
    }
}
