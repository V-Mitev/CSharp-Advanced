using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> contries = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!contries.ContainsKey(continent))
                {
                    contries.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!contries[continent].ContainsKey(country))
                {
                    contries[continent].Add(country, new List<string>());
                }

                contries[continent][country].Add(city);
            }

            foreach (var continent in contries)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var cities in continent.Value)
                {
                    Console.WriteLine($"{cities.Key} -> {string.Join(", ", cities.Value)}");
                }
            }
        }
    }
}