string input = Console.ReadLine();

SortedDictionary<char, int> charCount = new SortedDictionary<char, int>();

foreach (var ch in input)
{
    if (!charCount.ContainsKey(ch))
    {
        charCount[ch] = 0;
    }

    charCount[ch]++;
}

foreach (var ch in charCount)
{
    Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
}