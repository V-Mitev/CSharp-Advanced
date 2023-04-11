using System;
using System.Collections.Generic;
using System.Linq;

SortedDictionary<string, int> participantsPoints = new();
SortedDictionary<string, int> languagesSubmissions = new();

string command = Console.ReadLine();

while (command != "exam finished")
{
	string[] cmdArgs = command.Split('-');

	string name = cmdArgs[0];
	string cmdType = cmdArgs[1];

	if (cmdType == "banned")
	{
		participantsPoints.Remove(name);

		command = Console.ReadLine();

		continue;
	}

    string language = cmdArgs[1];
    int points = int.Parse(cmdArgs[2]);

	if (!participantsPoints.ContainsKey(name))
	{
		participantsPoints.Add(name, 0);
	}

	if (participantsPoints[name] < points)
	{
		participantsPoints[name] = points;
	}

    if (!languagesSubmissions.ContainsKey(language))
    {
        languagesSubmissions.Add(language, 0);
    }

    languagesSubmissions[language]++;

    command = Console.ReadLine();
}

Console.WriteLine("Results:");

foreach (var participantPoints in participantsPoints.OrderByDescending(p => p.Value))
{
    Console.WriteLine($"{participantPoints.Key} | {participantPoints.Value}");
}

Console.WriteLine("Submissions:");

foreach (var languageSubmissions in languagesSubmissions.OrderByDescending(l => l.Value))
{
    Console.WriteLine($"{languageSubmissions.Key} - {languageSubmissions.Value}");
}