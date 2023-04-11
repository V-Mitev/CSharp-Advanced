using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] ordersQueue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> quantityOfOrder = new Queue<int>(ordersQueue);
            int ordersCount = quantityOfOrder.Count;

            for (int i = 0; i < ordersCount; i++)
            {
                int currentOrder = quantityOfOrder.Peek();

                if (foodQuantity >= currentOrder)
                {
                    foodQuantity = foodQuantity - currentOrder;
                    quantityOfOrder.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (quantityOfOrder.Count == 0)
            {
                Console.WriteLine(ordersQueue.Max());
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(ordersQueue.Max());
                Console.WriteLine("Orders left: " + string.Join(" ", quantityOfOrder));
            }
        }
    }
}