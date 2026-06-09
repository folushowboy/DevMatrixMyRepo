using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class ReferenceParameter
    {
        public static void SimpleRefMethod(ref int k)
        {
            k = 501;
        }
    }
}
