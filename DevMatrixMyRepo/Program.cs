// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;
using System.Collections;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");

//Stack is last in first out (LIFO) data structure
Stack<string> stack = new Stack<string>();
stack.Push("a");
stack.Push("b");
stack.Push("c");
stack.Push("d");
stack.Push("e");


////Queue is first in first out (FIFO) data structure
//Queue<string> queue = new Queue<string>();
//queue.Enqueue("Toyato");
//queue.Enqueue("Honda");
//queue.Enqueue("Ford");
//queue.Enqueue("Chevrolet");
//queue.Enqueue("Nissam");

//Console.WriteLine("The total count:" + queue.Count()); //Count method returns the total number of elements in the queue
//Console.WriteLine("The first element:" + queue.Peek()); //Peek method returns the first element in the queue without removing it
//Console.WriteLine("The final count:" + queue.Dequeue()); //Dequeue method removes and returns the first element in the queue


////Dictionary
//Dictionary<int, string> dictionary = new Dictionary<int, string>();
//dictionary.Add(1, "C#");
//dictionary.Add(2, "Java");
//dictionary.Add(3, "Python");
//dictionary.Add(4, "JavaScript");
//dictionary.Add(5, "C++");

//foreach (var item in dictionary)
//{
//    Console.WriteLine("key: " + item.Key + ", Value: " + item.Value);
//}


////Linq 
//List<string> numbers = new List<string> { "chairs", "Bed", "Tv", "Table", "Frames", "Wall Clock", "Desk", "Jug" };

////Linq Query
////Query Syntax
//var result = from x in numbers
//             where x.Length == 3
//             select x; //We will use this for Dapper in .NET
//foreach (var y in result)
//{
//    Console.WriteLine(y);
//}

////Method Syntax / Fluent Syntax
//var secResult = numbers.Where(item => item.Length == 3);// We use this for Entity FrameWork in .NET
//foreach (var i in secResult)
//{
//    Console.WriteLine(i);
//}








//Methods in linq
//Filtering e.g where
//projection e.g select, selectmany
//ordering e.g orderby, orderbydescending, thenby, thenbydescending
//setoperators
//conversion methods
//elements operators
//aggregation methods
//quatifiers





////Filtering
//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

////method Syntax
//var highValues = numbers.Where(x => x > 4);
//foreach (var value in highValues)
//{
//    //Console.WriteLine(value);

//}

////query syntax

//var highVal = from x in numbers
//              where x > 4
//              select x;
//foreach (var value in highValues)
//{
//    //Console.WriteLine(value);
//}



////Projection
//List<Students> student = new List<Students>
//{
//    new Students { StudentId = 1 ,StudentName = "Ade", StudentAge = 20 },
//    new Students { StudentId = 2 ,StudentName = "Bola", StudentAge = 10 },
//    new Students { StudentId = 3 ,StudentName = "Shade", StudentAge = 15 },
//    new Students { StudentId = 4 ,StudentName = "Shayo", StudentAge = 14 },
//    new Students { StudentId = 5 ,StudentName = "Sunmi", StudentAge = 34 },
//    new Students { StudentId = 6 ,StudentName = "Debby", StudentAge = 28 },
//    new Students { StudentId = 7 ,StudentName = "Sunmi", StudentAge = 33 },
//    new Students { StudentId = 8 ,StudentName = "Bola", StudentAge = 21 },
//    new Students { StudentId = 9 ,StudentName = "Ade", StudentAge = 45 },

//};
////query Syntax
//var result = from x in student
//                 //select x.StudentName; // to select just one data
//             select new { x.StudentId, x.StudentName }; // to select more than one data
//foreach (var value in result)
//{
//    //Console.WriteLine($"{value.StudentId}. {value.StudentName}"); 
//}

////Method Syntax
//var answer = student.Select(x => x.StudentName); // to selct just one data
////var answer2 = student.Select( x => new { x.StudentName, x.StudentId}); // to select more than one data




////Ordering
////Method syntax
//var orderedStd = student.OrderBy(x => x.StudentAge).ThenBy(x => x.StudentName);

//foreach (var value in orderedStd)
//{
//    Console.WriteLine($"{value.StudentName}. {value.StudentAge}");
//}
////Query syntax
//var ordered = from x in student
//              orderby x.StudentName
//              select x;
//foreach (var value in orderedStd)
//{
//    //Console.WriteLine($"{value.StudentName}");
//}


////setOperator
////Distincts is to eliminate duplicate values from a collection
//List<int> FirstDigit = new List<int> { 4, 4, 5, 6, 6, 7, 8, 1, 1, 9, 9, 10, 11 };
//List<int> SecondDigit = new List<int> { 1, 2, 3, 4, 5, 5, 6, 9, 9, 8, 10 };

//var distincFirstDigit = FirstDigit.Distinct().Order();
//foreach (var digit in distincFirstDigit)
//{
//    //Console.WriteLine($"{digit}");
//}

////Intersect is to find a common element between two collection
//var intersectDigits = FirstDigit.Intersect(SecondDigit);
//foreach (var digit in intersectDigits)
//{
//    Console.WriteLine($"{digit}");
//}

////Union is to combine two collection into one collection
//var unionDigits = FirstDigit.Union(SecondDigit);
//foreach (var digit in intersectDigits)
//{
//    Console.WriteLine($"{digit}");
//}
////except is to find the element that are present in one collection but not in another
//var exceptDigits = FirstDigit.Except(SecondDigit);
//foreach (var digit in intersectDigits)
//{
//    Console.WriteLine($"{digit}");
//}


////conversion Method
//var Result = student.Select(x => x.StudentName).ToList();
//var data = student.ToDictionary(x => x.StudentId, x => x.StudentName);



//Element Operators
//first, firstordefault
//Last, lastordefault
//singles, singleordefault
//elementat, elementatordefault

List<string> alphaList = new List<string> { "A", "B", "C", "D", "E"};
List<int> numList = new List<int> { 1, 2, 3, 4, 5, 44, 66, 78, 89, 0 };
List<string> alphaList2 = new List<string> { };
List<int> numList2 = new List<int> { };

Console.WriteLine(alphaList.First());
Console.WriteLine(alphaList2.FirstOrDefault());
Console.WriteLine(numList.Last());
Console.WriteLine(numList2.LastOrDefault());
Console.WriteLine(alphaList.Single( x => x == "B"));
//Console.WriteLine(numList.SingleOrDefault()); // This only works when a collections has just one value
Console.WriteLine(alphaList.ElementAtOrDefault(2));



//Aggregation Method
//max, min, count, average, aggregate, sum

List<Students> student = new List<Students>
{
    new Students { StudentId = 1 ,StudentName = "Ade", StudentAge = 20 },
    new Students { StudentId = 2 ,StudentName = "Bola", StudentAge = 10 },
    new Students { StudentId = 3 ,StudentName = "Shade", StudentAge = 15 },
    new Students { StudentId = 4 ,StudentName = "Shayo", StudentAge = 14 },
    new Students { StudentId = 5 ,StudentName = "Sunmi", StudentAge = 34 },
    new Students { StudentId = 6 ,StudentName = "Debby", StudentAge = 28 },
    new Students { StudentId = 7 ,StudentName = "Sunmi", StudentAge = 33 },
    new Students { StudentId = 8 ,StudentName = "Bola", StudentAge = 21 },
    new Students { StudentId = 9 ,StudentName = "Ade", StudentAge = 45 },

};

var stdMax = student.Max(x => x.StudentAge);
Console.WriteLine(stdMax);

var stdMin = student.Min(x => x.StudentAge);
Console.WriteLine(stdMin);

var stdCount = student.Count();
Console.WriteLine(stdCount);

var stdSum = student.Sum(x => x.StudentAge);
Console.WriteLine(stdSum);

var stdLongCount = student.LongCount(); // Return long dataType
Console.WriteLine(stdSum);



//Quantifiers only returns boolean
//all, any, contains
var allStd = student.All(c => c.StudentAge > 18);
var anyStd = student.Any(c => c.StudentAge > 18);

var newstd = new Students { StudentId = 6, StudentName = "Debby", StudentAge = 28 };

var containStd = student.Any(s =>
    s.StudentId == newstd.StudentId &&
    s.StudentName == newstd.StudentName &&
    s.StudentAge == newstd.StudentAge); 
Console.WriteLine(containStd);









Console.ReadKey();

