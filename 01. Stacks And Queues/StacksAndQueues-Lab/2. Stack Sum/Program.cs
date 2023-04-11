using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                string action = cmdArgs[0];

                if (action == "add")
                {
                    int firstNumber = int.Parse(cmdArgs[1]);
                    int secondNumber = int.Parse(cmdArgs[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (action == "remove")
                {
                    int countOfElementsToRemove = int.Parse(cmdArgs[1]);

                    if (stack.Count >= countOfElementsToRemove)
                    {
                        for (int i = 0; i < countOfElementsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}