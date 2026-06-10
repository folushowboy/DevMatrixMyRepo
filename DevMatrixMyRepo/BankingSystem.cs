using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class BankingSystem
    {
        string FullName;
        string DOB;
        string Address;
        long PhoneNumber;
        string Email;

        public BankingSystem(string fname, string dob, string address, long phonenum, string email)
        {
            FullName = fname;
            DOB = dob;
            Address = address;
            PhoneNumber = phonenum;
            Email = email;
        }
        public void CreateAcct()
        {
            Console.WriteLine("Account has been created Successfully");
            Console.WriteLine($"FullName: {FullName}");
            Console.WriteLine($"Date Of Birth: {DOB}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");

        }
    }
}
