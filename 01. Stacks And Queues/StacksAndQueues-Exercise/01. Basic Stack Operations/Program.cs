using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberToPush = numbersArray[0];
            int numberToPop = numbersArray[1];
            int numberToContain = numbersArray[2];

            int[] numberList = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numberToPush; i++)
            {
                stack.Push(numberList[i]);
            }

            for (int i = 0; i < numberToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(numberToContain))
            {
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}