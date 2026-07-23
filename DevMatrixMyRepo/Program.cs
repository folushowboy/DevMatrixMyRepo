// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;
using static DevMatrixMyRepo.Employee;

Console.WriteLine("Hello, World!");

//List<Employee> ListOfEmployee = new List<Employee>
//{
//    new Employee { Id = 1, Name = "Aina", Age = 20, GenderIdentity = Gender.Male, DepartmentId = 1 },
//    new Employee { Id = 2, Name = "Job", Age = 16, GenderIdentity = Gender.Female, DepartmentId = 2 },
//    new Employee { Id = 3, Name = "John", Age = 18, GenderIdentity = Gender.Male, DepartmentId = 3 },
//    new Employee { Id = 4, Name = "Hauwa", Age = 10, GenderIdentity = Gender.Male, DepartmentId = 2 },
//    new Employee { Id = 5, Name = "Enny", Age = 25, GenderIdentity = Gender.Female, DepartmentId = 4 },
//    new Employee { Id = 6, Name = "Sammy", Age = 23, GenderIdentity = Gender.Male, DepartmentId = 1 },
//    new Employee { Id = 7, Name = "Jude", Age = 17, GenderIdentity = Gender.Female, DepartmentId = 2 },
//    new Employee { Id = 8, Name = "Eazy", Age = 30, GenderIdentity = Gender.Female, DepartmentId = 2 },
//    new Employee { Id = 9, Name = "Eze", Age = 29, GenderIdentity = Gender.Female, DepartmentId = 3},
//    new Employee { Id = 10, Name = "Seun", Age = 15, GenderIdentity = Gender.Male}
//};

//List<Department> ListOfDepartment = new List<Department>
//{
//    new Department { Id = 1, Name = "HR", Location = "New York" },
//    new Department { Id = 2, Name = "IT", Location = "San Francisco" },
//    new Department { Id = 3, Name = "Finance", Location = "Chicago" },
//    new Department { Id = 4, Name = "Marketing", Location = "Los Angeles" },
//    new Department { Id = 5, Name = "Sales", Location = "Houston" },
//};

////Query Syntax
//var InnerJoin = from emp in ListOfEmployee
//                join dept in ListOfDepartment on emp.DepartmentId equals dept.Id
//                select new { emp.Name, emp.Age, emp.GenderIdentity, 
//                    deptName = dept.Name, dept.Location };
//foreach(var empDept in InnerJoin)
//{
//    //Console.WriteLine($"{empDept.Name}, {empDept.GenderIdentity}, {empDept.deptName}, {empDept.Location}");
//}

////Method Syntax 
//var innerJoinMethod = ListOfEmployee.Join(ListOfDepartment, emp => emp.DepartmentId, dept => dept.Id,
//             (emp, dept) => new {
//             emp.Name, emp.GenderIdentity, deptName = dept.Name, dept.Location});
//foreach (var empDept in InnerJoin)
//{
//    //Console.WriteLine($"{empDept.Name}, {empDept.GenderIdentity}, {empDept.deptName}, {empDept.Location}");
//}


//var LeftJoin = from emp in ListOfEmployee // left list 
//               join dept in ListOfDepartment on emp.DepartmentId equals dept.Id into empDep
//               from dept in empDep.DefaultIfEmpty()
//               select new
//               { emp.Name, emp.GenderIdentity,
//               deptName = dept != null ? dept.Name : "No Department",
//               Location = dept != null ? dept.Location : "No Location" };
//foreach (var empDept in LeftJoin)
//{
//    //Console.WriteLine($"{empDept.Name}, {empDept.GenderIdentity}, {empDept.deptName}, {empDept.Location}");
//}


//var RightJoin = from dept in ListOfDepartment // Right list 
//                join emp in ListOfEmployee on dept.Id equals emp.DepartmentId into empdep
//                from emp in empdep.DefaultIfEmpty()
//               select new
//               { emp.Name, emp.GenderIdentity,
//               deptName = dept != null? dept.Name : "No Department",
//               Location = dept != null ? dept.Location : "No Location" };
//foreach (var empDept in RightJoin)
//{
//    Console.WriteLine($"{empDept.Name}, {empDept.GenderIdentity}, {empDept.deptName}, {empDept.Location}");
//}










List<Employee> employeesList = new List<Employee>
{
    new Employee{ Id = 1 ,Name = "Joe", Age = 20, GenderIdentity = Gender.Male, DepartmentId = 1 },
    new Employee{ Id = 2 ,Name = "Doe", Age = 15, GenderIdentity = Gender.Unknown, DepartmentId = 2 },
    new Employee{ Id = 3 ,Name = "Jude", Age = 18, GenderIdentity = Gender.Male,},
    new Employee{ Id = 4 ,Name = "John", Age = 23, GenderIdentity = Gender.Female, DepartmentId = 4 },
    new Employee{ Id = 5 ,Name = "Job", Age = 15, GenderIdentity = Gender.Male, DepartmentId = 6},
    new Employee{ Id = 6 ,Name = "Jack", Age = 27, GenderIdentity = Gender.Female, DepartmentId = 4 },
    new Employee{ Id = 7 ,Name = "June", Age = 29, GenderIdentity = Gender.Female, DepartmentId = 7 },
    new Employee{ Id = 8,Name = "Jospeh", Age = 13, GenderIdentity = Gender.Male, DepartmentId = 1 },
    new Employee{ Id = 9 ,Name = "Jollof", Age = 20, GenderIdentity = Gender.Male, DepartmentId = 2 },
    new Employee{ Id = 10 ,Name = "Jack", Age = 10, GenderIdentity = Gender.Female }
};

List<Department> departmentList = new List<Department>
{
    new Department { Id = 1, Name = "IT", Location = "Lagos"},
    new Department { Id = 2, Name = "Operations", Location = "Abuja"},
    new Department { Id = 3, Name = "Sales", Location = "Osun"},
    new Department { Id = 4, Name = "HR", Location = "Oyo"},
    new Department { Id = 5, Name = "Finances", Location = "Ibadan"}
};

//Querry Syntax
var InnerJoin = from emp in employeesList
                join dept in departmentList on emp.DepartmentId equals dept.Id
                select new { emp.Name, emp.GenderIdentity,
                    deptName = dept.Name, dept.Location };
foreach(var department in InnerJoin)
{
    //Console.WriteLine($"{department.Name}, {department.GenderIdentity}, {department.Location}, {department.deptName}");
}

//Method Syntax
var methodInnerJoin = employeesList.Join(departmentList, emp => emp.DepartmentId, dept => dept.Id, (emp, dept) => new { emp.Name, emp.GenderIdentity, deptName = dept.Name, dept.Location });
foreach(var department in methodInnerJoin)
{
    //Console.WriteLine($"{department.Name}, {department.GenderIdentity}, {department.Location}, {department.deptName}");
}

var leftJoin = from emp in employeesList
               join dept in departmentList on emp.DepartmentId equals dept.Id into empdept
               from dept in empdept.DefaultIfEmpty()
               select new
               {
                   emp.Name, emp.GenderIdentity,
                   deptName = dept != null ? dept.Name : "No Department",
                   Location = dept != null ? dept.Location : "No Location"
               };
foreach (var department in leftJoin)
{
    Console.WriteLine($"{department.Name}, {department.GenderIdentity}, {department.Location}, {department.deptName}");
}