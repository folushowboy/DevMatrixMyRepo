using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class UserDetails
    {
        //public int Id;
        //public string UserName;
        //public int Age;

        //public UserDetails(int id, string name, int age)
        //{
        //    Id = id;
        //    UserName = name;
        //    Age = age;
        //}

        //public void UserInfo()
        //{
        //    Console.WriteLine("User Id is {0}", Id);
        //    Console.WriteLine("User Name is {0}", UserName);
        //    Console.WriteLine("User Age is {0}", Age);
        //}



        //int Id;
        //string UserName;
        //int Age;
        public UserDetails(int id, string uname, int age)
        {
            //id = id;
            //UserName = uname;
            //Age = age;

            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"User Name: {uname}");
            Console.WriteLine($"Age: {age}");
        }





    }
}
