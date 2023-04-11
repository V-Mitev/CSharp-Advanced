using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            int rowsCount = int.Parse(input[0]);
            int colsCount = int.Parse(input[1]);
            int sum = 0;

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

            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colsCount; col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rowsCount);
            Console.WriteLine(colsCount);
            Console.WriteLine(sum);
        }
    }
}