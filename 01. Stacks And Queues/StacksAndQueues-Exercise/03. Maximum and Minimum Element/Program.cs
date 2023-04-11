using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int typeOfInt = array[0];

                if (typeOfInt == 1)
                {
                    int numToPush = array[1];

                    stack.Push(numToPush);
                }
                else if (typeOfInt == 2)
                {
                    stack.Pop();
                }
                else if (typeOfInt == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else
                    {

                    }

                }
                else if (typeOfInt == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    else
                    {

                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}