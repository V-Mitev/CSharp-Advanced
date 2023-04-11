using System;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            bool matrixContainsSymbol = false;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string line = Console.ReadLine();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = line[cols];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            int rowIndex = 0;
            int colIndex = 0;

            IsMatrixContainsSymbol(matrix, ref matrixContainsSymbol, symbol, ref rowIndex, ref colIndex);

            if (matrixContainsSymbol)
            {
                Console.WriteLine($"({rowIndex}, {colIndex})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }

        static void IsMatrixContainsSymbol(int[,] matrix, ref bool isMatrixContainsSymbol, char symbol, ref int rowIndex, ref int colIndex)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == symbol)
                    {
                        isMatrixContainsSymbol = true;

                        rowIndex = rows;
                        colIndex = cols;

                        return;
                    }
                }
            }
        }
    }
}