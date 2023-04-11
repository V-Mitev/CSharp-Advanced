int n = int.Parse(Console.ReadLine());

SortedSet<string> set = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    string[] elements = Console.ReadLine().Split();

    set.UnionWith(elements);
}

Console.WriteLine(string.Join(' ', set));