// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;

Console.WriteLine("Hello, World!");

int i = 101;
ValueParameter.SimpleMethod(i);
Console.WriteLine(i); //Since it's passing a parameter by value, the result will be 0, cause the value of i is 0. I.e, the result is determined by the value of what is being invoked or called.

int m = 0;
ReferenceParameter.SimpleRefMethod(ref m);
Console.WriteLine(m); // Since it's passing a parameter by reference, the result will be the value in the method it is refering to, cause the value of k is 501. I.e, the result is determined by the value of the method it is referencing to.

//OutParameter.SimpleOutParameter(10, 20, out int sum, out int product);
//Console.WriteLine($"Sum is = {sum} && Product is = {product}");

OutParameter.paramSimp(23, 5, 3, out int divide, out int multiply, out int modulus);
Console.WriteLine($"Division = {divide}");
Console.WriteLine($"Multiplication = {multiply}");
Console.WriteLine($"Modulus = {modulus}");

int[] Numbers = new int[5];
Numbers[0] = 11;
Numbers[1] = 12;
Numbers[2] = 13;
Numbers[3] = 14;
Numbers[4] = 15;

ParameterArray.SimpleArrParameter(Numbers);
//Console.WriteLine(Numbers);