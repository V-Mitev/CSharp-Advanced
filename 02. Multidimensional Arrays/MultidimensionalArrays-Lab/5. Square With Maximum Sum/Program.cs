using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            int rowsCount = int.Parse(input[0]);
            int colsCount = int.Parse(input[1]);
            int currentSum = 0;

            int[,] matrix = new int[rowsCount, colsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                int[] line = Console.ReadLine().Split(", ")
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int maxSum = int.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int rows = 0; rows < rowsCount - 1; rows++)
            {
                for (int cols = 0; cols < colsCount - 1; cols++)
                {
                    currentSum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        selectedRow = rows;
                        selectedCol = cols;
                    }
                }
            }

            Console.WriteLine($"{matrix[selectedRow, selectedCol]} {matrix[selectedRow, selectedCol + 1]}");
            Console.WriteLine($"{matrix[selectedRow + 1, selectedCol]} {matrix[selectedRow + 1, selectedCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}