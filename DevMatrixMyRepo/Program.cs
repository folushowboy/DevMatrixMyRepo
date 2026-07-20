// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Path
string Path = @"C:\Users\DELL\Documents\My Web Sites\Vocabulary.txt";
string sentence = "Welcome to the file ready block.";

File.WriteAllText(Path, sentence);
var value = File.ReadAllText(Path);
Console.WriteLine(value);

var val = Directory.GetParent(value);
Console.WriteLine(val);