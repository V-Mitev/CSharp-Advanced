List<string> output = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Action<string> printNames = name => Console.WriteLine(name);

output.ForEach(printNames);