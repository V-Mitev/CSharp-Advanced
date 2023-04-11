int length = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine()
	.Split(' ', StringSplitOptions.RemoveEmptyEntries)
	.ToList();

Predicate<string> isLengthValid = name => name.Length <= length;

Func<List<string>, Predicate<string>, List<string>> nameValidator = (names, length) =>
{
	List<string> result = new List<string>();

	foreach (var name in names)
	{
		if (isLengthValid(name))
		{
			result.Add(name);
		}
	}

	return result;
};

List<string> validNames = new List<string>();

validNames = nameValidator(names, isLengthValid);

foreach (var name in validNames)
{
	Console.WriteLine(name);
}