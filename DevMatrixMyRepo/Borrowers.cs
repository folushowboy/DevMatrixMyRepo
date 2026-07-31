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

        public static void BorrowABook(List<Borrowers> borrowbook, List<Books> books)
        {
            Console.WriteLine("Enter Tilte to borrow book");
            string choice = Console.ReadLine();
            //var booksToBorrow = borrowbook.FirstOrDefBorrowedBooksault(x => x.);
        }
    }
}
