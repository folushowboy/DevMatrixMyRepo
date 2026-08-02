using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class Borrowers
    {
        public int BorrowerID { get; set; }
        public string FullName { get; set; }
        public long PhoneNumber { get; set; }
        public string BorrowLimit { get; set; }

        //public List<Books> books { get; set; } = new List<Books>();

       
    }
}
