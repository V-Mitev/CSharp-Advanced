List<int> input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Func<List<int>, List<int>> operation = null;

Action<List<int>> print = list => Console.WriteLine(String.Join(" ", list));

string command = Console.ReadLine();

while (command != "end")
{
    if (command == "add")
    {
        operation = number => number.Select(number => number += 1).ToList();
        input = operation(input);
    }
    else if (command == "subtract")
    {
        operation = number => number.Select(number => number -= 1).ToList();
        input = operation(input);
    }
    else if (command == "multiply")
    {
        operation = number => number.Select(number => number *= 2).ToList();
        input = operation(input);
    }
    else if (command == "print")
    {
        print(input);
    }

    command = Console.ReadLine();
}