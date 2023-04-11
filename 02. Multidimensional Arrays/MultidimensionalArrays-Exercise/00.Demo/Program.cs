using System;
using System.Linq;

int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int row = 0;row < matrix.GetLength(0); row++)
{
	int[] numbers = Console.ReadLine()
		.Split(' ', StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse)
		.ToArray();

	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		matrix[row, col] = numbers[col];
	}
}

string[] bombCordinates = Console.ReadLine()
	.Split(' ', StringSplitOptions.RemoveEmptyEntries);

foreach (var bomb in bombCordinates)
{
	string[] bombIndex = bomb.Split(',', StringSplitOptions.RemoveEmptyEntries);

	int row = int.Parse(bombIndex[0]);
	int col = int.Parse(bombIndex[1]);

	BombExplode(row, col, matrix);
}

int aliveCells = 0;
int sumOfAliveCells = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] > 0)
        {
            aliveCells++;
            sumOfAliveCells += matrix[row, col];
        }
    }
}

Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sumOfAliveCells}");

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }

    Console.WriteLine();
}

void BombExplode(int row, int col, int[,] matrix)
{
	int value = matrix[row, col];

	if (value > 0)
	{
        matrix[row, col] = 0;

		//top
		if (row > 0 && matrix[row - 1, col] > 0)
		{
			matrix[row- 1, col] -= value;
		}

        //top left
        if (row > 0 && col > 0 && matrix[row - 1, col - 1] > 0)
        {
            matrix[row - 1, col - 1] -= value;
        }

        //top right
        if (row > 0 && col < matrix.GetLength(1) - 1 && matrix[row - 1, col + 1] > 0)
        {
            matrix[row - 1, col + 1] -= value;
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

        //bottom
        if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] > 0)
        {
            matrix[row + 1, col] -= value;
        }

        //bottom left
        if (row < matrix.GetLength(0) - 1 && col > 0 && matrix[row + 1, col - 1] > 0)
        {
            matrix[row + 1, col - 1] -= value;
        }

        //bottom right
        if (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 && matrix[row + 1, col + 1] > 0)
        {
            matrix[row + 1, col + 1] -= value;
        }
    }
}