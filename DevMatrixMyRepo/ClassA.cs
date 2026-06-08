using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class ClassA : IStudent
    {
        public string name = "George";
        public int Age = 55;

        public void Click()
        {
            Console.WriteLine("Plase Click me");
        }

        public void Migrate()
        {
            Console.WriteLine("Plase Migrate me");
        }

        public void MyDetails()
        {
            Console.WriteLine("Welcome to the user info page");
        }

        public void Register()
        {
            Console.WriteLine("Register your user info");
        }
    }
}
