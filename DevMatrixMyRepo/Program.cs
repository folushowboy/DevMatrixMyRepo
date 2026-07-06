// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

//Stack is last in first out (LIFO) data structure



//Queue is first in first out (FIFO) data structure
Queue<string> queue = new Queue<string>();
queue.Enqueue("Toyato");
queue.Enqueue("Honda");
queue.Enqueue("Ford");
queue.Enqueue("Chevrolet");
queue.Enqueue("Nissam");

Console.WriteLine("The total count:" + queue.Count()); //Count method returns the total number of elements in the queue
Console.WriteLine("The first element:" + queue.Peek()); //Peek method returns the first element in the queue without removing it
Console.WriteLine("The final count:" + queue.Dequeue()); //Dequeue method removes and returns the first element in the queue


//Dictionary
Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1,"C#");
dictionary.Add(2, "Java");
dictionary.Add(3, "Python");
dictionary.Add(4, "JavaScript");
dictionary.Add(5, "C++");

foreach(var item in dictionary)
{
    Console.WriteLine("key: " + item.Key  + ", Value: " + item.Value);
}


//Linq 
List<string> numbers = new List<string> {"chairs", "Bed", "Tv", "Table", "Frames", "Wall Clock", "Desk", "Jug" };

//Linq Query
//Query Syntax
var result = from number in numbers
             where number.Length > 4
             select number; //We will use this for Dapper in .NET
foreach(var item in result)
{
    Console.WriteLine(item);
}

//Method Syntax / Fluent Syntax
var secResult = numbers.Where(item => item.Length == 3);// We use this for Entity FrameWork in .NET
foreach (var i in secResult)
{
    Console.WriteLine(i);
}
