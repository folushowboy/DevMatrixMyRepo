using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo  // namespace
{ 
    public class UserDetails // class
    {
        public int Id; // field
        public string UserName; // field
        public int Age; // field

        public UserDetails(int id, string name, int age) // constructor
        {
            Id = id; // assigning the value of the parameter to the field 
            UserName = name; // assigning the value of the parameter to the field
            Age = age; // assigning the value of the parameter to the field
        }

        public void UserInfo() // method
        {
            Console.WriteLine("User Id is {0}", Id);
            Console.WriteLine("User Name is {0}", UserName);
            Console.WriteLine("User Age is {0}", Age);
        }

    }
}
