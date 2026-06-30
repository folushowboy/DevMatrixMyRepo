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
            Console.WriteLine("\n");
            Console.WriteLine("Available Products\n");
            foreach (AddToCart prd in products)
            {
                Console.WriteLine($"{prd.Id}. {prd.Name}. {prd.price}");
            }
        }

        public static void AddProductToCart(List<AddToCart> products, List<AddToCart> cart)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Add to Cart\n");
            Console.WriteLine("Enter Product Id to add to cart");
            string UserAnswer = "Y";
            while (UserAnswer == "Y")
            {
                if (!int.TryParse(Console.ReadLine(), out int UserChoice))
                {
                    Console.WriteLine("Ivalid input. Number must be between 1 and 10");
                    continue;
                }
                AddToCart selectedProduct = products.FirstOrDefault(p => p.Id == UserChoice);
                if (selectedProduct != null)
                {
                    cart.Add(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to cart");
                    Console.WriteLine("Add more product to cart? Y/N");
                    UserAnswer = Console.ReadLine().ToUpper();

                }
                else
                {
                    Console.WriteLine("Product not found");
                }
            }

        }

        public static void RemoveProductFromCart(List<AddToCart> products, List<AddToCart> cart)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Remove from Cart\n");
            Console.WriteLine("Enter Product Id to remove from from cart");
            string userAnswer = "Y";
            while (userAnswer == "Y")
            {
                if (cart.Count == 0)
                {
                    Console.WriteLine("Cart is empty");
                    continue;
                }
                if (!int.TryParse(Console.ReadLine(), out int UserChoice))
                {
                    Console.WriteLine("Ivalid input. Number must be between 1 and 10");
                    continue;
                }
                AddToCart removeProduct = products.FirstOrDefault(r => r.Id == UserChoice);
                if (removeProduct != null)
                {
                    cart.Remove(removeProduct);
                    Console.WriteLine($"{removeProduct.Name} removed from cart");
                    Console.WriteLine($"Remove more products from cart? Y/N");
                    userAnswer = Console.ReadLine().ToUpper();

                }
                else
                {
                    Console.WriteLine("Product not found");
                }
            }

        }

        public static void ViewProduct(List<AddToCart> products, List<AddToCart> cart)
        {
            Console.WriteLine("\n");
            Console.WriteLine("View Cart\n");
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
                return;
            }
            decimal total = 0;

            foreach (AddToCart prd in cart)
            {
                Console.WriteLine($"{prd.Name}. {prd.price}");
                total += prd.price;

            }
            Console.WriteLine($"Items = {cart.Count}");
            Console.WriteLine($"Total = {total}");
        }

        public static void CheckOut(List<AddToCart> products, List<AddToCart> cart)
        {
            Console.WriteLine("\n");
            Console.WriteLine("View Cart\n");
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
                return;
            }
            Console.WriteLine($"Proceed Checkout? Y/N");
            string userAnswer = Console.ReadLine().ToUpper();

            if (userAnswer == "Y")
            {
                Console.WriteLine("Payment Successful!");
                Console.WriteLine("Thank you for shopping with us.");

            }
            else
            {
                Console.WriteLine("Checkout cancelled.");
            }


        }


    }
}
