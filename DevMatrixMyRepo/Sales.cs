using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Sales
    {

        //Access Modifiers: public, private, protected, internal, protected internal, private protected
        //data
        //field
        //preperty
        //method/methods
        //indexer
        //constructor
        //destructor


        public int x = 33; // field
        public string name { set; get; } // property
        public void SalesDetails() // method
        {
            Console.WriteLine(x);
        }
        public static int SalesInfo()
        {
            return 10;
        }
    }
}
