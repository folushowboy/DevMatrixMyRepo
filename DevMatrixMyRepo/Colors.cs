using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{

    public abstract class Colors
    {
        int x = 89;
        public string Name { get; set; }

        public void DisplayColor()
        {
            Console.WriteLine($"The color is {Name}");
        }

       public abstract void UpdateColor(); // Abstract method
    }
}
