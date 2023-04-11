using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(arrayOfNumbers);
            int sumOfBox = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int counterForBox = 1;

            while (stack.Any())
            {
                if (currentSum + stack.Peek() <= sumOfBox)
                {
                    currentSum += stack.Pop();
                }
                else 
                {
                    counterForBox++;
                    currentSum = 0;
                }
            }

            Console.WriteLine(counterForBox);
        }
    }
}
