// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;

Console.WriteLine("Hello, World!");

int i = 0;
ValueParameter.SimpleMethod(i);
Console.WriteLine(i); //Since it's passing a parameter by value, the result will be 0, cause the value of i is 0. I.e, the result is determined by the value of what is being invoked or called.