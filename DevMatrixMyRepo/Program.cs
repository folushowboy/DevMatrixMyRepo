// See https://aka.ms/new-console-template for more information
using DevMatrixMyRepo;

Console.WriteLine("Hello, World!");

Signalling sig = new Signalling();
sig.ProcessCompleted += ActionClass.ActionRequired;
sig.StartProcess();
