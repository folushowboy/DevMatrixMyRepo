// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;

Console.WriteLine("Hello, World!");

Console.WriteLine(BasicCalcGame.Multiply(2.23, 4.45, 68.9));
Console.WriteLine(BasicCalcGame.Subtract(224, 445, 758));

BasicCalcGame add = new BasicCalcGame();
add.Add(323, 654, 876);

BasicCalcGame divide = new BasicCalcGame();
Console.WriteLine( divide.Divide(23456, 5678, 7890));