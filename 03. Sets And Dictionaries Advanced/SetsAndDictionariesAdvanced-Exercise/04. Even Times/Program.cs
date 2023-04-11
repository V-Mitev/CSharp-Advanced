int n = int.Parse(Console.ReadLine());

Dictionary<int, int> evenNumbersCount = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    int numbers = int.Parse(Console.ReadLine());

	if (!evenNumbersCount.ContainsKey(numbers))
	{
		evenNumbersCount[numbers] = 0;
	}

	evenNumbersCount[numbers]++;
}

foreach (var number in evenNumbersCount)
{
	if (number.Value % 2 == 0)
	{
		Console.WriteLine(number.Key);
	}
}