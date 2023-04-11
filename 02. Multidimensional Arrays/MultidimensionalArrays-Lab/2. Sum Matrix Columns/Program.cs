using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            int rowsCount = int.Parse(input[0]);
            int colsCount = int.Parse(input[1]);

            int[,] matrix = new int[rowsCount, colsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                int[] line = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            for (int col = 0; col < rowsCount; col++)
            {
                int sum = 0;

                for (int row = 0; row < colsCount; row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}