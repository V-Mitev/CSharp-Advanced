using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> reservationList = new HashSet<string>();

            while (command != "PARTY")
            {
                reservationList.Add(command);

                command = Console.ReadLine();
            }

            while (command != "END") 
            {
                reservationList.Remove(command);

                command = Console.ReadLine();
            }

            Console.WriteLine(reservationList.Count);

            foreach (var item in reservationList)
            {
                char[] ch = item.ToCharArray();

                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }

            foreach (var item in reservationList)
            {
                char[] ch = item.ToCharArray();

                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}