// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;

Console.WriteLine("Hello, World!");

for (int i = 0; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}


string[] names = { "Genesis", "mathew", "exodus", "luke", "Samuel", "Mark", "Romans", "Titus", "Peter", "Jude", "Kings", "Ezekeil", "Moses", "Sarah", "Adam", "Eve", "Esther", "Obadiah", "Lamb", "Jesus" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

Conditional condition = new Conditional();
condition.ConditionalIf();

Conditional.ConditionalSwitch();

Conditional sales = new Conditional();
sales.SaleApp();
