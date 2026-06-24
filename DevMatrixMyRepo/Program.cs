// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;

//Console.WriteLine("Hello, World!");
//List <DelegateClass> ListOfStudents = new List <DelegateClass> ();
//ListOfStudents.Add(new DelegateClass { Name = "Odusina Tolu", Id = 101, Department = "Chemistry", Level = 100, Age = 10 });
//ListOfStudents.Add(new DelegateClass { Name = "Adedeji Sam", Id = 102, Department = "Biology", Level = 300, Age = 20 });
//ListOfStudents.Add(new DelegateClass { Name = "Aguda Grace", Id = 103, Department = "Physics", Level = 100, Age = 30 });
//ListOfStudents.Add(new DelegateClass { Name = "Afolabi Funke", Id = 104, Department = "Geology", Level = 400, Age = 40 });
//ListOfStudents.Add(new DelegateClass { Name = "Dapo Lawal", Id = 105, Department = "Insurance", Level = 200, Age = 50 });
//ListOfStudents.Add(new DelegateClass { Name = "Oke Mordy", Id = 106, Department = "Elect elect", Level = 500, Age = 70 });
//ListOfStudents.Add(new DelegateClass { Name = "George Flow", Id = 107, Department = "Geography", Level = 100, Age = 60 });
//ListOfStudents.Add(new DelegateClass { Name = "Grace Law", Id = 108, Department = "Acturial Sciences", Level = 200, Age = 80 });


//PromoteDeStudentslegate stud = new PromoteDeStudentslegate(PromoteStudents);
//DelegateClass.PromoteStudents(ListOfStudents, stud);

//static bool PromoteStudents(DelegateClass students)
//{
//    if(students.Age <= 18)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}


//static bool PromoteStudentsLevel(DelegateClass students)
//{
//    if (students.Level <= 100)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}



























List<DelegateSamples1> listOfStudents = new List<DelegateSamples1>();
listOfStudents.Add(new DelegateSamples1 { Name = "Odusina", Age = 20, Level = 100 });
listOfStudents.Add(new DelegateSamples1 { Name = "Sam", Age = 18, Level = 300 });
listOfStudents.Add(new DelegateSamples1 { Name = "Tolu", Age = 15, Level = 200 });
listOfStudents.Add(new DelegateSamples1 { Name = "Mordy", Age = 22, Level = 200 });
listOfStudents.Add(new DelegateSamples1 { Name = "Emma", Age = 17, Level = 400 });

//SampleDelegate del = new SampleDelegate(IsEligible);
//DelegateSamples1.DisplayStudentInfo(listOfStudents, del);
DelegateSamples1.DisplayStudentInfo(listOfStudents, st => st.Age >= 18);


//bool IsEligible(DelegateSamples1 students)
//{
//    if (students.Age >= 18)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}







