// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Asynchronous Programming


await LastProcess();
await FirstProcess();
//Synchronous Method
static async Task FirstProcess()
{
    Console.WriteLine("Welcome to the first process");
    Console.WriteLine("The first process is starting now......");
    Console.WriteLine("The first process is completed.");
}

//Asynchronous Method
static async Task LastProcess()
{
    Console.WriteLine("Welcome to the Last process");
    await Task.Delay(1000);
    Console.WriteLine("The Last process is starting now......");
    Console.WriteLine("The Last process is completed.");

    //await DateReturnProcess(); // To call an asynchronous method it has to be in an asynchronous main method
}

static async void Last() // Same thing as Task
{
   
}
//Asynchronous DataType Method
static async Task<bool> DateReturnProcess()
{
    return true;
}

//Synchronous DataType Method
static bool DataProcess()
{
    return true;

}