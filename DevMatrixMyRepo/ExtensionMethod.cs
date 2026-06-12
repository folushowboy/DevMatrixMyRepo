using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    //Extension Method
    //keyword is this
    //Must be a static class
    internal static class ExtensionMethod
    {
        //must be a static must and th parameter must start with a this keyword
        public static int RegionCount(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            var result = input.Split(new char[] {' ', '\t', '\n'},
                    StringSplitOptions.RemoveEmptyEntries);
                return result.Length;

        }
    }
}
