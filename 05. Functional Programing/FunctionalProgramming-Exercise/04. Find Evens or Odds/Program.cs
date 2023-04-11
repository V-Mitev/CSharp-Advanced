int[] input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

List<int> rangeOfNumbers = new List<int>();

int startNumber = input[0];
int endNumber = input[1];

for (int i = startNumber; i <= endNumber; i++)
{
    rangeOfNumbers.Add(i);
}

string command = Console.ReadLine();

Predicate<int> predicate = null;

if (command == "odd")
{
    predicate = number => number % 2 != 0;
}
else
{
    predicate = number => number % 2 == 0;
}

Console.WriteLine(string.Join(' ', rangeOfNumbers.FindAll(predicate)));