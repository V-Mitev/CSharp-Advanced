﻿using System;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); 

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            string[] bombs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var indexePair in bombs)
            {
                int[] indices = indexePair.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int row = indices[0];
                int col = indices[1];

                Explode(matrix, row, col);
            }

            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        static void Explode(int[,] matrix, int row, int col)
        {
            int value = matrix[row, col];

            if (value > 0)
            {
                matrix[row, col] = 0;

                //top
                if (row > 0 && matrix[row - 1, col] > 0)
                {
                    matrix[row - 1, col] -= value;
                }

                //bottom
                if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] > 0)
                {
                    matrix[row + 1, col] -= value;
                }

                //left
                if (col > 0 && matrix[row, col - 1] > 0)
                {
                    matrix[row, col - 1] -= value;
                }

                //right
                if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] > 0)
                {
                    matrix[row, col + 1] -= value;
                }

                //top left
                if (row > 0 && col > 0 && matrix[row - 1, col - 1] > 0)
                {
                    matrix[row - 1, col - 1] -= value;
                }

                //bottom left
                if (row < matrix.GetLength(0) - 1 && col > 0 && matrix[row + 1, col - 1] > 0)
                {
                    matrix[row + 1, col - 1] -= value;
                }

                //top right
                if (row > 0 && col < matrix.GetLength(1) - 1 && matrix[row - 1, col + 1] > 0)
                {
                    matrix[row - 1, col + 1] -= value;
                }

                //bottom right
                if (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 && matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= value;
                }
            }
        }
    }
}