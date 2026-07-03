// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;

Console.WriteLine("Hello, World!");

List<AddToCart> listOfProducts = new List<AddToCart>();
listOfProducts.Add(new AddToCart { Id = 1, Name = "Rice", price = 4555 });
listOfProducts.Add(new AddToCart { Id = 2, Name = "Beans", price =3550 });
listOfProducts.Add(new AddToCart { Id = 3, Name = "Milk", price = 1800 });
listOfProducts.Add(new AddToCart { Id = 4, Name = "Bread", price = 1200 });
listOfProducts.Add(new AddToCart { Id = 5, Name = "Eggs", price = 2250 });
listOfProducts.Add(new AddToCart { Id = 6, Name = "Yam", price = 2250 });
listOfProducts.Add(new AddToCart { Id = 7, Name = "Custard", price = 2250 });
listOfProducts.Add(new AddToCart { Id = 8, Name = "Potatoes", price = 2250 });
listOfProducts.Add(new AddToCart { Id = 9, Name = "Apple", price = 2250 });
listOfProducts.Add(new AddToCart { Id = 10, Name = "MeatPie", price = 2250 });

List<AddToCart> cart = new List<AddToCart>();

AddToCart.ViewProduct(listOfProducts);
AddToCart.AddProductToCart(listOfProducts, cart);
AddToCart.ViewCart(cart);
AddToCart.RemoveProductFromCart(listOfProducts, cart);
AddToCart.ViewCart(cart);
AddToCart.CheckOut(listOfProducts, cart);














































//List<AddToCart> listOfItems = new List<AddToCart>();
//listOfItems.Add(new AddToCart() { itemId = 1, ItemName = "BlackCoffee ", ItemPrice = 1550 });
//listOfItems.Add(new AddToCart() { itemId = 2, ItemName = "Espresso ", ItemPrice = 2000 });
//listOfItems.Add(new AddToCart() { itemId = 3, ItemName = "Americano ", ItemPrice = 3550 });
//listOfItems.Add(new AddToCart() { itemId = 4, ItemName = "Latte ", ItemPrice = 1000 });
//listOfItems.Add(new AddToCart() { itemId = 5, ItemName = "Cappuccino ", ItemPrice = 2300 });
//listOfItems.Add(new AddToCart() { itemId = 6, ItemName = "Macchiato ", ItemPrice = 5550 });
//listOfItems.Add(new AddToCart() { itemId = 7, ItemName = "Mocha ", ItemPrice = 5000 });
//listOfItems.Add(new AddToCart() { itemId = 8, ItemName = "Flat White ", ItemPrice = 3300 });
//listOfItems.Add(new AddToCart() { itemId = 9, ItemName = "Doppio ", ItemPrice = 1850 });
//listOfItems.Add(new AddToCart() { itemId = 10, ItemName = "Affogato ", ItemPrice = 2500 });

//List<AddToCart> cart = new List<AddToCart>();
//AddToCart.ViewProduct(listOfItems);
//AddToCart.AddProduct(listOfItems, cart);