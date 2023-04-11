using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    queue.Enqueue(arrayOfNumbers[i]);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}