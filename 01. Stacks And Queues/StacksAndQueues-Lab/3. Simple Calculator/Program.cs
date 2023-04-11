using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();

            int result = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                stack.Push(expression[i]);

                if (stack.Count == 3)
                {
                    int firstNumber = int.Parse(stack.Pop());
                    var sign = stack.Pop();
                    int secondNumber = int.Parse(stack.Pop());

                    if (sign == "+")
                    {
                        result = firstNumber + secondNumber;
                    }
                    if (sign == "-")
                    {
                        result = secondNumber - firstNumber;
                    }

                    stack.Push(result.ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}