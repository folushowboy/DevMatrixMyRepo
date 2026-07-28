using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public static class Extension //It must be static for both class and method
    {
        public static bool IsGreaterThan(this int a, int b) // must have a dataType and must have thsi This keyword
        {
            return a > b;
        }
    }
}
