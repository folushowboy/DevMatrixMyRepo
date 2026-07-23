using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Gender GenderIdentity { get; set; }
        public int Age { get; set; }

        public enum Gender
        {
            Male,
            Female,
            Unknown
        }

    }
}
