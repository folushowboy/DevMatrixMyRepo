// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Path
string path = @"C:\Users\User\OneDrive\Documents\My Web Sites\vocabulary.txt";
string senence = "Jesus loves you";
File.WriteAllText(path, senence);
var value = Directory.GetLastAccessTime(path);
Console.WriteLine(value);