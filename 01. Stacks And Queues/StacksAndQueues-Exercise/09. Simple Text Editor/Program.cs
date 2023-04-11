using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> memory = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                string numberOfCommand = command[0];

                if (numberOfCommand == "1")
                {
                    memory.Push(sb.ToString());
                    string textToAdd = command[1];

                    sb.Append(textToAdd);
                }
                else if (numberOfCommand == "2")
                {
                    memory.Push(sb.ToString());
                    int elementsToRemove = int.Parse(command[1]);
                    
                    sb.Remove(sb.Length - elementsToRemove, elementsToRemove);
                }
                else if (numberOfCommand == "3")
                {
                    int elemntPosition = int.Parse(command[1]);

                    Console.WriteLine(sb[elemntPosition - 1]);
                }
                else if (numberOfCommand == "4")
                {
                    sb = new StringBuilder(memory.Pop());
                }
            }
        }
    }
}