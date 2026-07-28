using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class BankingSystem
    {
        public static void CreateAccount(string name, long phoneNumber, int initialDeposit)
        {
            Console.WriteLine("FullName: {0}", name);
            Console.WriteLine("Phone Number: {0}", phoneNumber);
            Console.WriteLine("Initial Depossit: {0}", initialDeposit);

            Deposit(initialDeposit);
        }
        public static void Deposit(int initialDeposit)
        {
            Console.WriteLine("\nEnter amount to Deposit to your account");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid input. Enter only numbers.");
            }
            double balance = initialDeposit + amount;
            Console.WriteLine($"\nBalance = {balance}");

            Withdrawal(balance);
        }
        public static void Withdrawal(double balance)
        {
            Console.WriteLine("Enter amount to withdraw? ");
            double amount = 0;
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid input. Enter only numbers.");
                }
                else if(amount > balance)
                {
                    Console.WriteLine("Insufficient fund. Fund your account.");
                    break;
                }
                balance -= amount;
                Console.WriteLine($"Amount withdrawn: {amount}");
                Console.WriteLine($"Balance: {balance}");
            }
           
        }
    }
}
