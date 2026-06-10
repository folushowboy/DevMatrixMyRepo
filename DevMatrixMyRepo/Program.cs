// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;

//Console.WriteLine("Hello, World!");

BankingSystem bank = new BankingSystem("Odusina Tolulope", "30/01/2000" , "Lagos", 09077867875, "odusinat8@gmail.com");
bank.CreateAcct();

AccountDeposit depo = new AccountDeposit(15000);
//depo.AcctWithdrawal();
depo.CheckBalance();

