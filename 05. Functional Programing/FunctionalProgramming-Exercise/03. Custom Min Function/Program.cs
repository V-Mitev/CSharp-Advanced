List<int> input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Func<List<int>, int> getMinElement = list => list.Min();

Console.WriteLine(getMinElement(input));