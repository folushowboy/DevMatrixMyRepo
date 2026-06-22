using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public delegate bool PromoteDeStudentslegate(DelegateClass students);
    public class DelegateClass
    {
          
      public string Name { get; set; }
      public int Id { get; set; }
      public string Department { get; set; }
      public int Level { get; set; }
      public int Age { get; set; }

        public static void PromoteStudents(List<DelegateClass> students, PromoteDeStudentslegate Ispromotable)
        {
            foreach(var std in students)
            {
                if(Ispromotable(std))
                {
                    std.Level += 100;
                    Console.WriteLine($"{std.Name}  has been promoted to {std.Level}");
                }
            }
        }
    }
}
