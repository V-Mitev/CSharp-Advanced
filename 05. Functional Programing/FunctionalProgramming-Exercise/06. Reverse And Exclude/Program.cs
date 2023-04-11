List<int> numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Reverse()
    .ToList();

int divider = int.Parse(Console.ReadLine());

Predicate<int> isDivisible = n => n % divider == 0;

Func<List<int>, Predicate<int>, List<int>> divviedNumber = (numbers, divider) =>
{
    List<int> result = new();

    foreach (var number in numbers)
    {
        if (!divider(number))
        {
            result.Add(number);
        }
    }

    return result;
};

numbers = divviedNumber(numbers, isDivisible);

Console.WriteLine(string.Join(' ', numbers));