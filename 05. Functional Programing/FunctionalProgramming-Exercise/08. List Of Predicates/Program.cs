int range = int.Parse(Console.ReadLine());

HashSet<int> numbersToDivide = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

List<Predicate<int>> predicates = new();

foreach (var divider in numbersToDivide)
{
    predicates.Add(p => p % divider == 0);
}

List<int> numbers = new List<int>();

for (int i = 1;i <= range; i++)
{
    numbers.Add(i);
}

foreach (var number in numbers)
{
    bool isDivisible = true; // predicates.All(match => match(number));

    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isDivisible = false;
            break;
        }
    }

    if (isDivisible)
    {
        Console.Write($"{number} ");
    }
}