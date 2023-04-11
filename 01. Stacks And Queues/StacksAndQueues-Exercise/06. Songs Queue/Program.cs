using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] song = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(song);

            while (songs.Any())
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string commandType = cmdArgs[0];

                if (commandType == "Play")
                {
                    songs.Dequeue();
                }
                else if (commandType == "Add")
                {
                    string songToAdd = string.Join(" ", cmdArgs.Skip(1));

                    if (songs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                        continue;
                    }
                    else
                    {
                        songs.Enqueue(songToAdd);
                    }
                }
                else if (commandType == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}