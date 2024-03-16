// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Hello, World!");
Console.WriteLine("modification 1");
Console.WriteLine("modification 2");
Console.WriteLine("modification 3");

var numbers = Enumerable.Range(0,10).ToArray();

Console.WriteLine($"This is my average: {Utilities.Average(numbers)}");
Console.WriteLine($"The max element: {Utilities.MaxElement(numbers)}");