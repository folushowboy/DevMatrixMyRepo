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

        public static void ViewBorrowedBooks(List<Books> borrowedBooks)
        {
            Console.WriteLine("\nList of Borrowed Books\n");
            foreach (Books BB in borrowedBooks)
            {
                Console.WriteLine($"Title: {BB.Title}, Author: {BB.Author} is borrowed by ");
            }
        }


    }
}
