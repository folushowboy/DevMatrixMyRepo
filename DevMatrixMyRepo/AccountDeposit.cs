using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class AccountDeposit
    {
        int initialDeposit = 1000;
        int subsequentDeposit;

        public AccountDeposit(int subdeposit)
        {
            subsequentDeposit = subdeposit;
        }

        public void AcctWithdrawal() 
        {
            Console.WriteLine($"{initialDeposit} has been initially deposited into your account");
            int balance = initialDeposit + subsequentDeposit;
            Console.WriteLine($"You have credited your account with {subsequentDeposit}");
            Console.WriteLine($"Balance: {balance}");

            int cashwithdrwaal = 0;
            while(balance > 0)
            {
                Console.WriteLine("Please withdraw any amount within your limit");

                if (!int.TryParse(Console.ReadLine(), out cashwithdrwaal))
                {
                    Console.WriteLine("Invalid input. Enter a whole number");
                    continue;
                }else if(cashwithdrwaal >= balance)
                {
                    Console.WriteLine("Insufficient balance");
                    break;
                }
                balance = balance - cashwithdrwaal;
                Console.WriteLine($"{cashwithdrwaal} has been withdrawn from your account");
                Console.WriteLine($"Balance: {balance}");

            }
        }

        public void CheckBalance()
        {
            int balance = initialDeposit + subsequentDeposit;
            Console.WriteLine($"Account Balance: {balance}");        
        }


    }
}
