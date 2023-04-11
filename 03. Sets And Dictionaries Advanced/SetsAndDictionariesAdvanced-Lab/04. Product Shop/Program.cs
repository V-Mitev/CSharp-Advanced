using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string[] cmdArgs = command.Split(", ");

                string shopName = cmdArgs[0];
                string productName = cmdArgs[1];
                double price = double.Parse(cmdArgs[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName,new Dictionary<string, double>());
                }

                shops[shopName][productName] = price;

                command = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}