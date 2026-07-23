// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;
using System.Collections;

Console.WriteLine("Hello, World!");

//Stack is last in first out (LIFO) data structure



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

////filtering
//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
////Query Syntax
//var filterNum = from x in numbers
//                where x > 4  // filter
//                select x;

////Dictionary
//Dictionary<int, string> dictionary = new Dictionary<int, string>();
//dictionary.Add(1,"C#");
//dictionary.Add(2, "Java");
//dictionary.Add(3, "Python");
//dictionary.Add(4, "JavaScript");
//dictionary.Add(5, "C++");

//foreach(var item in dictionary)
//{
//    Console.WriteLine("key: " + item.Key  + ", Value: " + item.Value);
//}


////Linq 
//List<string> numbers = new List<string> {"chairs", "Bed", "Tv", "Table", "Frames", "Wall Clock", "Desk", "Jug" };

////Linq Query
////Query Syntax
//var result = from number in numbers
//             where number.Length > 4
//             select number; //We will use this for Dapper in .NET
//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}

////Method Syntax / Fluent Syntax
//var secResult = numbers.Where(item => item.Length == 3);// We use this for Entity FrameWork in .NET
//foreach (var i in secResult)
//{
//    Console.WriteLine(i);
//}


Stack<Student> studentStackList = new Stack<Student>();
studentStackList.Push(new Student { StudentId = 1, StudentName = "Samuel", StudentAge = 20 });
studentStackList.Push(new Student { StudentId = 2, StudentName = "John", StudentAge = 15 });
studentStackList.Push(new Student { StudentId = 3, StudentName = "Tolu", StudentAge = 18 });
studentStackList.Push(new Student { StudentId = 4, StudentName = "Young", StudentAge = 2 });
studentStackList.Push(new Student { StudentId = 5, StudentName = "Jack", StudentAge = 2 });


Queue<Student> studentList = new Queue<Student>();
studentList.Enqueue(new Student { StudentId = 1, StudentName = "Samuel", StudentAge = 20});
studentList.Enqueue(new Student { StudentId = 2, StudentName = "John", StudentAge = 15 });
studentList.Enqueue(new Student { StudentId = 3, StudentName = "Tolu", StudentAge = 18 });
studentList.Enqueue(new Student { StudentId = 4, StudentName = "Young", StudentAge = 2 });
studentList.Enqueue(new Student { StudentId = 5, StudentName = "Jack", StudentAge = 2 });

//Student.DisplayStudents(studentList);  
//Student.DisplayStudentsgreaterthan18(studentList);



Dictionary<int, string> ListStudent = new Dictionary<int, string>();
ListStudent.Remove(1);
ListStudent.Add(2, "Man");
ListStudent.Add(3, "Jam");
ListStudent.Add(4, "Seun");


//StudentsDictionary.StdsDictionary(ListStudent);


//LINQ
List<string> numbers = new List<string> {"chairs", "Bed", "Tv", "Table", "Frames", "Wall Clock", "Desk", "Jug" };

var QueryLinq = from num in numbers
                where num.Length > 3
                select num;
foreach(var selectNum in QueryLinq)
{
    //Console.WriteLine(selectNum);
}

var MethodLinq = numbers.Where(x => x.Length > 4);
foreach(var selectNum in MethodLinq)
{
    //Console.WriteLine(selectNum);
}




List<int> NumInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 2, 5, 4, 3, 7, 9, 10 };
List<int> Num2 = new List<int> { 10, 20, 30, 40, 50, 6, 7, 2, 5, 42, 34, 76, 98, 10 };

var distinc = NumInt.Contains(4);
Console.WriteLine(distinc);




