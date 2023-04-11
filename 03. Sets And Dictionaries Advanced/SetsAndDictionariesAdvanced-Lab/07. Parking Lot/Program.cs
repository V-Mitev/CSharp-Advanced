using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();

            while (command != "END")
            {
                string[] parkingInfo = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string direction = parkingInfo[0];
                string carnumber = parkingInfo[1];

                if (direction == "IN")
                {
                    set.Add(carnumber);
                }
                else
                {
                    set.Remove(carnumber);
                }

                command = Console.ReadLine();
            }

            if (set.Count > 0)
            {
                foreach (var cars in set)
                {
                    Console.WriteLine(cars);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}