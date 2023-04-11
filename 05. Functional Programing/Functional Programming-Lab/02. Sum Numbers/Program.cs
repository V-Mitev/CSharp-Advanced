int[] input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(Parse)
    .ToArray();

Console.WriteLine(input.Length);
Console.WriteLine(input.Sum());

static int Parse(string input) 
{
    return int.Parse(input);
}