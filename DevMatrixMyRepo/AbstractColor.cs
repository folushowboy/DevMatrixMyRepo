using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class AbstractColor : Colors
    {
        public static void Add(int a, int b)
        {
            var y = a + b;
            Console.WriteLine(y);
        }
        public static void Add(double y, double x, double z)
        {
            var a = y + x + z;
            Console.WriteLine(a);

        }
        public static void Add(int x, int y, int z)
        {
            var f = y + x + z;
            Console.WriteLine(f);

        }

        public override void DeleteColor()
        {
           int result = 20 * 10;
            Console.WriteLine(result);
        }

        //public override void PupilType()
        //{
        //    Console.WriteLine("Pupil Type Abstract");
        //}

        //public override void PupilValue()
        //{
        //    Console.WriteLine("Pupil Value Abstract");
        //}

        public override void UpdateColor(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }
    }
}
