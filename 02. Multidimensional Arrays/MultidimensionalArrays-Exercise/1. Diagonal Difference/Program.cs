using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int finalSum = 0;
            int leftToRightDiagonal = 0;
            int rightToLeftDiagonal = 0;

            for (int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int i = 0, j = size - 1; i < size; i++, j--)
            {
                leftToRightDiagonal += matrix[i, i]; 
                rightToLeftDiagonal += matrix[i, j];
            }

            //int counter = 0;

            //for (int i = size - 1; i >= 0; i--)
            //{
            //    rightToLeftDiagonal += matrix[counter, i];
            //    counter++;
            //}

            Console.WriteLine(Math.Abs(finalSum = leftToRightDiagonal - rightToLeftDiagonal));
        }
    }
}