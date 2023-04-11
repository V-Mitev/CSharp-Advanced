using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                int[] cols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                jaggedArray[row] = cols;
            }

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split();

                string cmdType = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (cmdType == "Add")
                {
                    if (row >= 0 && row < jaggedArray.Length &&
                        col >= 0 &&  col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else if (cmdType == "Subtract")
                {
                    if (row >= 0 && row < jaggedArray.Length &&
                        col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}