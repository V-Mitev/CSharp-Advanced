using System;
using System.Collections.Generic;
using System.Linq;

SortedDictionary<string, SortedSet<string>> forceUsers = new SortedDictionary<string, SortedSet<string>>();

string command = Console.ReadLine();

while (command != "Lumpawaroo")
{
    if (command.Contains(" | ")) 
    {
        string[] cmdargs = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

        string side = cmdargs[0];
        string user = cmdargs[1];

        if (!forceUsers.Values.Any(u => u.Contains(user)))
        {
            if (!forceUsers.ContainsKey(side))
            {
                forceUsers.Add(side, new SortedSet<string>());
            }

            forceUsers[side].Add(user);
        }
    }
    else
    {
        string[] cmdargs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

        string user = cmdargs[0];
        string side = cmdargs[1];

        foreach (var member in forceUsers)
        {
            if (member.Value.Contains(user))
            {
                member.Value.Remove(user);
                break;
            }
        }

        if (!forceUsers.ContainsKey(side))
        {
            forceUsers[side] = new SortedSet<string>();
        }

        forceUsers[side].Add(user);

        Console.WriteLine($"{user} joins the {side} side!");
    }

    command = Console.ReadLine();
}

Dictionary<string, SortedSet<string>> orderedSidesUsers = forceUsers
    .OrderByDescending(s => s.Value.Count)
    .ToDictionary(s => s.Key, s => s.Value);

foreach (var side in orderedSidesUsers)
{
    if (side.Value.Count > 0)
    {
        Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

        foreach (var user in side.Value)
        {
            Console.WriteLine($"! {user}");
        }
    }
}