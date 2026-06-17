using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class InheritanceDerived : InheritanceBase, IDrive
    {
        public void CarColor()
        {
            Console.WriteLine("Car color is red");
        }
        public void CarName()
        {
            Console.WriteLine("Car Name is Camry");
        }

        public void CarYear()
        {
            Console.WriteLine("Car Year is 2020");
        }
    }
}
