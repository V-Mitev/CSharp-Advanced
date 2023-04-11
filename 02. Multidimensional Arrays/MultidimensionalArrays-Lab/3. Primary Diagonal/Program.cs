using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int sum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = line[cols];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                    sum += matrix[row, row];   
            }

            Console.WriteLine(sum);
        }
    }
}