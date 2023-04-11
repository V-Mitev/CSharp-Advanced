List<string> input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Action<string> printNames = name => Console.WriteLine($"Sir {name}");

input.ForEach(printNames);