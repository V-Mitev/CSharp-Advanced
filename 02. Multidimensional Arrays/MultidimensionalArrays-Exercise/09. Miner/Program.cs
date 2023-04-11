using System;
using System.Linq;

int size = int.Parse(Console.ReadLine());

char[,] matrix = new char[size, size];

int startRow = 0;
int startCol = 0;
int coalsCount = 0;

string[] directions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

for (int row = 0; row < size; row++)
{
    char[] chars = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = chars[col];

        if (matrix[row, col] == 's')
        {
            startRow = row;
            startCol = col;
        }
        else if (matrix[row, col] == 'c')
        {
            coalsCount++;
        }
    }
}

MoveMiner(startRow, startCol, matrix, coalsCount, directions);

static void MoveMiner(int startRow, int startCol, char[,] matrix, int coalsCount, string[] directions)
{
    int currRow = startRow;
    int currCol = startCol;

    foreach (var move in directions)
    {
        if (move == "up")
        {
            currRow--;

            if (currRow >= 0 && currRow < matrix.GetLength(1))
            {
                if (matrix[currRow, currCol] == 'c')
                {
                    coalsCount--;
                    matrix[currRow, currCol] = '*';
                }
                else if (matrix[currRow, currCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currRow}, {currCol})");
                    return;
                }
            }
            else
            {
                currRow++;
            }
        }
        else if (move == "down")
        {
            currRow++;

            if (currRow < matrix.GetLength(1))
            {
                if (matrix[currRow, currCol] == 'c')
                {
                    coalsCount--;
                    matrix[currRow, currCol] = '*';
                }
                else if (matrix[currRow, currCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currRow}, {currCol})");
                    return;
                }
            }
            else
            {
                currRow--;
            }
        }
        else if (move == "right")
        {
            currCol++;

            if (currCol < matrix.GetLength(1))
            {
                if (matrix[currRow, currCol] == 'c')
                {
                    coalsCount--;
                    matrix[currRow, currCol] = '*';
                }
                else if (matrix[currRow, currCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currRow}, {currCol})");
                    return;
                }
            }
            else
            {
                currCol--;
            }
        }
        else if (move == "left")
        {
            currCol--;

            if (currCol >= 0 && currCol < matrix.GetLength(1))
            {
                if (matrix[currRow, currCol] == 'c')
                {
                    coalsCount--;
                    matrix[currRow, currCol] = '*';
                }
                else if (matrix[currRow, currCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currRow}, {currCol})");
                    return;
                }
            }
            else
            {
                currCol++;
            }
        }
    }

    if (coalsCount > 0)
    {
        Console.WriteLine($"{coalsCount} coals left. ({currRow}, {currCol})");
    }
    else
    {
        Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
    }
}