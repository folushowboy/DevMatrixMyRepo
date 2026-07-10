// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;
using System.Collections;

Console.WriteLine("Hello, World!");

//Stack is last in first out (LIFO) data structure
Stack<string> stack = new Stack<string>();
stack.Push("a");
stack.Push("b");
stack.Push("c");
stack.Push("d");
stack.Push("e");



Queue<HospitalQueue> Patients = new Queue<HospitalQueue>();
Patients.Enqueue(new HospitalQueue { Name = "Tolulope", Sickness = "Headache", medicine = "Paracetamol" });
Patients.Enqueue(new HospitalQueue { Name = "Samuel", Sickness = "Acl", medicine = "OTC pain killers" });
Patients.Enqueue(new HospitalQueue { Name = "Anjola", Sickness = "Muscle Pull", medicine = "Rub" });
Patients.Enqueue(new HospitalQueue { Name = "Sharon", Sickness = "Menstrual pain", medicine = "Naproxen " });
Patients.Enqueue(new HospitalQueue { Name = "Eze", Sickness = "Leg pain", medicine = "Ibuprofen" });
Patients.Enqueue(new HospitalQueue { Name = "John", Sickness = "Running Temperature", medicine = "Paracetamol" });
Patients.Enqueue(new HospitalQueue { Name = "Jude", Sickness = "Malaria", medicine = "Artemether" });


//HospitalQueue.HospitalPatient(Patients);

Dictionary<int, string> listOfStudents = new Dictionary<int, string>();
listOfStudents.Add(101, "Samuel");
listOfStudents.Add(102, "Ezekeil");
listOfStudents.Add(103, "Emmanuel");
listOfStudents.Add(104, "Paul");
listOfStudents.Add(105, "Mordecai");
listOfStudents.Add(106, "Silas");
listOfStudents.Add(107, "Tolulope");
listOfStudents.Add(108, "Israal");
listOfStudents.Add(109, "Bolu");
listOfStudents.Add(110, "Sharon");

StudentsDictionary.StdsDictionary(listOfStudents);


List<StudentsLinq> linqOfStudents = new List<StudentsLinq>();
linqOfStudents.Add(new StudentsLinq { Name = "Tolulope", Score = 40 });
linqOfStudents.Add(new StudentsLinq { Name = "Samuel", Score = 75 });
linqOfStudents.Add(new StudentsLinq { Name = "Eze", Score = 55 });
linqOfStudents.Add(new StudentsLinq { Name = "Seun", Score = 37 });


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
//foreach(var value in result)
//{
//    //Console.WriteLine($"{value.StudentId}. {value.StudentName}"); 
//}

////Method Syntax
//var answer = student.Select(x => x.StudentName); // to selct just one data
////var answer2 = student.Select( x => new { x.StudentName, x.StudentId}); // to select more than one data




////Ordering
////Method syntax
//var orderedStd = student.OrderBy(x => x.StudentAge).ThenBy(x => x.StudentName);

//foreach(var value in orderedStd)
//{
//    Console.WriteLine($"{value.StudentName}. {value.StudentAge}");
//}
////Query syntax
//var ordered = from x in student
//              orderby x.StudentName
//              select x;
//foreach(var value in orderedStd)
//{
//    //Console.WriteLine($"{value.StudentName}");
//}


////setOperator
////Distincts is to eliminate duplicate values from a collection
//List<int> FirstDigit = new List<int> { 4, 4, 5, 6, 6, 7, 8, 1, 1, 9, 9, 10, 11 };
//List<int> SecondDigit = new List<int> { 1, 2, 3, 4, 5, 5, 6, 9, 9, 8, 10 };

//var distincFirstDigit = FirstDigit.Distinct().Order();
//foreach(var digit in distincFirstDigit)
//{
//    //Console.WriteLine($"{digit}");
//}

////Intersect is to find a common element between two collection
//var intersectDigits = FirstDigit.Intersect(SecondDigit);
//foreach(var digit in intersectDigits)
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