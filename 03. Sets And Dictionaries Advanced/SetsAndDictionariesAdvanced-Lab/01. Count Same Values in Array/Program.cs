using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Dictionary<double, int> numberOcc = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numberOcc.ContainsKey(number))
                {
                    numberOcc.Add(number, 0);
                }

                numberOcc[number]++;
            }

            foreach (var item in numberOcc)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}