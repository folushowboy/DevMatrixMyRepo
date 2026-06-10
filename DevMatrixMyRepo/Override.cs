using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Override : MethodOverloading
    {
        public override void GetStudent()
        {
            {
                Console.WriteLine("This is method Override class");
            }
        }
    }
}
