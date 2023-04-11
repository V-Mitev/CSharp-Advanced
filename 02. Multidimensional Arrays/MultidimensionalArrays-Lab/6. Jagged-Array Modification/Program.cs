using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rowsCount][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] cmdArgs = command.Split();

                string cmdType = cmdArgs[0];

                if (cmdType == "Subtract")
                {
                    int row = int.Parse(cmdArgs[1]);
                    int col = int.Parse(cmdArgs[2]);
                    int value = int.Parse(cmdArgs[3]);

                    if (row >= 0 && row < jaggedArray.Length && 
                        col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (cmdType == "Add")
                {
                    int row = int.Parse(cmdArgs[1]);
                    int col = int.Parse(cmdArgs[2]);
                    int value = int.Parse(cmdArgs[3]);

                    if (row >= 0 && row < jaggedArray.Length &&
                        col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }
    }
}