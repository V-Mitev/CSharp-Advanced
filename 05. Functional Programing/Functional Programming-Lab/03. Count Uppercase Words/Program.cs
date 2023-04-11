Predicate<string> upperCase = s => s[0] == char.ToUpper(s[0]);

    string[] input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Where(w => upperCase(w))
    .ToArray();

foreach (var item in input)
{
    Console.WriteLine(item);
}