using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public abstract class Pupils
    {
        public string Name { get; }
        public int x = 30;

        public void PupilName()
        {
            Console.WriteLine("My Name is Sam");
        }
        public abstract void PupilValue();

        public abstract void PupilType();
    }
}
