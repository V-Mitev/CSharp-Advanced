using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> customerName = new Queue<string>();

            while (command != "End")
            {
                if (command != "Paid")
                {
                    customerName.Enqueue(command);
                }
                else
                {
                    while (customerName.Count > 0)
                    {
                        Console.WriteLine(customerName.Dequeue());
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{customerName.Count} people remaining.");
        }
    }
}