﻿int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();

for (int i = 0; i < input[0]; i++)
{
    firstSet.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < input[1]; i++)
{
    secondSet.Add(int.Parse(Console.ReadLine()));
}

firstSet.IntersectWith(secondSet);

Console.WriteLine(string.Join(' ', firstSet));