HashSet<string> set = new HashSet<string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    set.Add(Console.ReadLine());
}

foreach (var name in set)
{
    Console.WriteLine(name);
}