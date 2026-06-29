using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class AddToCart
    {
        public int Id { get; set; }
        public string ItemName { get; set;}
        public int ItemPrice { get; set;}

        public static void ViewProduct(List<AddToCart> items) 
        {
            Console.WriteLine("Welcome to the Add-To-Cart website. What would you like to order?");
            Console.WriteLine("select your order by picking the order number ");

            foreach(AddToCart item in items)
            {
                Console.WriteLine($"{item.Id}, {item.ItemName}, {item.ItemPrice}");
            }

            int price = 0;
            string coffeName = "";
            string answer = "YES";
            while (answer == "YES")
            {
                if (!int.TryParse(Console.ReadLine(), out int UserChoice))
                {
                    Console.WriteLine("Invalid Input. Must be numbers");
                    continue;
                }
                else if(UserChoice > 10)
                {
                    Console.WriteLine("Number is greater than the items we have. Choose between 1 and 10 to choose your order.");
                }
               
                switch (UserChoice)
                {
                    case 1:
                        coffeName = "BlackCoffee";
                        price = 500;
                        break;
                    case 2:
                        coffeName = "Espresso";
                        price = 1500;
                        break;
                    case 3:
                        coffeName = "Americano";
                        price = 6000;
                        break;
                    case 4:
                        coffeName = "Latte";
                        price = 2000;
                        break;
                    case 5:
                        coffeName = "Cappuccino";
                        price = 3500;
                        break;
                    case 6:
                        coffeName = "Macchiato";
                        price = 2550;
                        break;
                    case 7:
                        coffeName = "Mocha";
                        price = 4250;
                        break;
                    case 8:
                        coffeName = "Flat White ";
                        price = 1500;
                        break;
                    case 9:
                        coffeName = "Doppio";
                        price = 2300;
                        break;
                    case 10:
                        coffeName = "Affogato";
                        price = 3400;
                        break;
                }
                Console.WriteLine($"You picked {coffeName}");
                Console.WriteLine("Do you still want to pick more item? YES/NO");
                 answer = Console.ReadLine().ToUpper();
                //int total = price 
            }        
        }

        public static void AddProductToCart(int UserChoice)
        {
            Console.WriteLine("Add to cart using the item ID");
        } 
    }
}
