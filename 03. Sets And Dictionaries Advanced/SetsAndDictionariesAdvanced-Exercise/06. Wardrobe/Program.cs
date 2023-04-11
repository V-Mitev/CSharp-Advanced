Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

    string color = command[0];

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());
    }

    for (int j = 1; j < command.Length; j++)
    {
        string currentClothing = command[j];

        if (!wardrobe[color].ContainsKey(currentClothing))
        {
            wardrobe[color].Add(currentClothing, 0);
        }

        wardrobe[color][currentClothing]++;
    }
}

string[] findParams = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var clothByColor in wardrobe)
{
    Console.WriteLine($"{clothByColor.Key} clothes:");

    foreach (var cloth in clothByColor.Value)
    {
        string printItem = $"* {cloth.Key} - {cloth.Value}";

        if (clothByColor.Key == findParams[0] && cloth.Key == findParams[1])
        {
            printItem += " (found!)";
        }

        Console.WriteLine(printItem);
    }
}