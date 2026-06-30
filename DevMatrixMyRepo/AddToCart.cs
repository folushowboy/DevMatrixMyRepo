using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class AddToCart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }

        public static void ViewProduct(List<AddToCart> products)
        {
            Console.WriteLine("Available Product");
            foreach(AddToCart prd in products)
            {
                Console.WriteLine($"{prd.Id}, {prd.Name}, {prd.price}");
            }
        }

        public static void AddProductToCart(List<AddToCart> products, List<AddToCart> cart)
        {
            string question = "YES";
            while (question == "YES")
            {
                Console.WriteLine("Enter Product Id to add to cart");
                if(!int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    Console.WriteLine("Invalid input. Must be numbers between 1 and 10");
                    continue;
                }

                AddToCart selectedPrd = products.FirstOrDefault(p => p.Id == userChoice);
                if(selectedPrd != null)
                {
                    cart.Add(selectedPrd);
                    Console.WriteLine("{0} added to cart", selectedPrd.Name);
                    Console.WriteLine("Wanna add more products to your cart? YES/N0");
                    question = Console.ReadLine().ToUpper();
                    continue;
                }
                else
                {
                    Console.WriteLine("Product not found");

                }
            }
        }

        public static void RemoveProductFromCart(List<AddToCart> products, List<AddToCart> cart)
        {
            string question = "YES";
            while (question == "YES")
            {
                Console.WriteLine("Enter Product Id to remove from cart");
                if (!int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    Console.WriteLine("Invalid input. Must be numbers between 1 and 10");
                }
                if (cart.Count == 0)
                {
                    Console.WriteLine("Cart is empty");
                    continue;
                }
                AddToCart removeprd = products.FirstOrDefault(r => r.Id == userChoice);
                if(removeprd != null)
                {
                    cart.Remove(removeprd);
                    Console.WriteLine($"{removeprd.Name} removed from cart");
                    Console.WriteLine("Wanna add more products to your cart? YES/N0");
                    question = Console.ReadLine().ToUpper();
                    continue;
                }
                else
                {
                    Console.WriteLine("Product not found");
                }
            }

        }

        public static void ViewCart(List<AddToCart> products, List<AddToCart> cart)
        {
            while(true)
            {
                if (cart.Count == 0)
                {
                    Console.WriteLine("Cart is empty");
                    continue;
                }
                decimal total = 0;

                foreach(AddToCart prd in cart)
                {
                    Console.WriteLine($"{prd.Id}. {prd.Name} - ${prd.price}");
                    total += prd.price;

                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"Items: {cart.Count}");
                    Console.WriteLine($"Total: ₦{total}");
                    break;
                }
            }

        }















































        //public int itemId { get; set; }
        //public string ItemName { get; set; }
        //public int ItemPrice { get; set; }
        //public static void ViewProduct(List<AddToCart> products)
        //{
        //    Console.WriteLine("Welcome. What would you like to order?");
        //    Console.WriteLine("Pick the Id to order.");
        //    foreach (AddToCart prd in products)
        //    {
        //        Console.WriteLine($"{prd.itemId}, {prd.ItemName}, {prd.ItemPrice}");
        //    }
        //} 

        //public static void AddProduct(List<AddToCart> products, List<AddToCart> cart)
        //{
        //    string userAns = "YES";
        //    while (userAns == "YES")
        //    {
        //        Console.WriteLine("Enter Product Id: ");
        //        if (!int.TryParse(Console.ReadLine(), out int userGuess))
        //        {
        //            Console.WriteLine("Invalid Input");
        //            continue;
        //        }
        //        AddToCart selectedPrd = products.FirstOrDefault(item => item.itemId == userGuess); // To link the item Id to the userGuess, i.e when the user picks a number between 1 and 10 (Id) it displays the product in the number picked.
        //        if(selectedPrd != null)
        //        {
        //            cart.Add(selectedPrd); //To add it to the cart
        //            Console.WriteLine($"{selectedPrd.ItemName} added to cart."); // To print a message that te=he product has been added to the cart.
        //            Console.WriteLine("Wanna add more products to cart? YES/NO");
        //            userAns = Console.ReadLine().ToUpper();
        //            continue;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Product not found");
        //        }
        //    }
        //}
    }
}
