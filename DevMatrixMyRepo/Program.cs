// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;

Console.WriteLine("Hello, World!");

List<AddToCart> listOfItems = new List<AddToCart>();
listOfItems.Add(new AddToCart() { Id = 1, ItemName = "BlackCoffee ", ItemPrice = 1550 });
listOfItems.Add(new AddToCart() { Id = 2, ItemName = "Espresso ", ItemPrice = 2000 });
listOfItems.Add(new AddToCart() { Id = 3, ItemName = "Americano ", ItemPrice = 3550 });
listOfItems.Add(new AddToCart() { Id = 4, ItemName = "Latte ", ItemPrice = 1000 });
listOfItems.Add(new AddToCart() { Id = 5, ItemName = "Cappuccino ", ItemPrice = 2300 });
listOfItems.Add(new AddToCart() { Id = 6, ItemName = "Macchiato ", ItemPrice = 5550 });
listOfItems.Add(new AddToCart() { Id = 7, ItemName = "Mocha ", ItemPrice = 5000 });
listOfItems.Add(new AddToCart() { Id = 8, ItemName = "Flat White ", ItemPrice = 3300 });
listOfItems.Add(new AddToCart() { Id = 9, ItemName = "Doppio ", ItemPrice = 1850 });
listOfItems.Add(new AddToCart() { Id = 10, ItemName = "Affogato ", ItemPrice = 2500 });

AddToCart.ViewProduct(listOfItems);