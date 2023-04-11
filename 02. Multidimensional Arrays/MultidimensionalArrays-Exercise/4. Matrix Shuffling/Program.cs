using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            int rows = sizeOfMatrix[0];
            int cols = sizeOfMatrix[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = strings[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] cmdType = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (isCommandValid(cmdType, sizeOfMatrix))
                {
                    string tempValue = matrix[int.Parse(cmdType[1]), int.Parse(cmdType[2])];
                    matrix[int.Parse(cmdType[1]), int.Parse(cmdType[2])] = 
                        matrix[int.Parse(cmdType[3]), int.Parse(cmdType[4])];
                    matrix[int.Parse(cmdType[3]), int.Parse(cmdType[4])] = tempValue;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        static bool isCommandValid(string[] cmdType, int[] dimensions) 
        {
            return cmdType[0] == "swap" && cmdType.Length == 5
                && int.Parse(cmdType[1]) >= 0 && int.Parse(cmdType[1]) < dimensions[0]
                && int.Parse(cmdType[2]) >= 0 && int.Parse(cmdType[2]) < dimensions[1]
                && int.Parse(cmdType[3]) >= 0 && int.Parse(cmdType[3]) < dimensions[0]
                && int.Parse(cmdType[4]) >= 0 && int.Parse(cmdType[4]) < dimensions[1];
        }
    }
}