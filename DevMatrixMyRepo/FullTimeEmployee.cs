using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class FullTimeEmployee : Employee
    {
        public new void DisplayEmployeeInfo() //The new key word makes the base method hidden and the derived method invoked.
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine("I love yam and egg");
            Console.WriteLine("Jesus is lord");
        }
    }
}
