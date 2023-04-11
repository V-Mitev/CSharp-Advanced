using System;
using System.Linq;

double[] prices = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .Select(d => d * 1.2)
    .ToArray();

foreach (var item in prices)
{
    Console.WriteLine($"{item:F2}");
}