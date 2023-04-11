using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = sizeOfMatrix[0];
            int cols = sizeOfMatrix[1];
            int counter = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => char.Parse(x))
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row , col] == matrix[row + 1, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}