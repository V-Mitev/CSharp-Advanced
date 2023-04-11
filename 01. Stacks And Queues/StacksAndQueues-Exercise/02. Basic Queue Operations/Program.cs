using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberToPush = numbersArray[0];
            int numberToPop = numbersArray[1];
            int numberToContain = numbersArray[2];

            int[] numberList = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numberToPush; i++)
            {
                queue.Enqueue(numberList[i]);
            }

            for (int i = 0; i < numberToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(numberToContain))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}