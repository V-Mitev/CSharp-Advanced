using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sorted = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x=>x).Take(3).ToArray();

            foreach (var item in sorted)
            {
                Console.Write($"{item} ");
            }
        }
    }
}