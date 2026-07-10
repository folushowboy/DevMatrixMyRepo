// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;
using System.Collections;

Console.WriteLine("Hello, World!");

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
