using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int durationOfFreeWindow = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            Queue<string> queueOfCars = new Queue<string>();
            int couterPassedCars = 0;

            while (command != "END")
            {
                if (command == "green")
                {
                    int greenLight = durationOfGreenLight;
                    int freeWindow = durationOfFreeWindow;
                    int counter = queueOfCars.Count;

                    for (int i = 0; i < counter; i++)
                    {
                        if (queueOfCars.Peek().Length <= greenLight)
                        {
                            greenLight -= queueOfCars.Peek().Length;
                            queueOfCars.Dequeue();
                            couterPassedCars++;
                        }
                        else if (queueOfCars.Peek().Length > greenLight)
                        {
                            int totalSeconds = greenLight + freeWindow;

                            if (greenLight <= 0)
                            {
                                continue;
                            }

                            if (totalSeconds >= queueOfCars.Peek().Length)
                            {
                                totalSeconds -= queueOfCars.Peek().Length;
                                queueOfCars.Dequeue();
                                couterPassedCars++;
                                greenLight = 0;
                            }
                            else if (queueOfCars.Count > 0 &&
                                totalSeconds < queueOfCars.Peek().Length)
                            {
                                string car = queueOfCars.Peek();
                                int hit = totalSeconds;
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[hit]}.");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    queueOfCars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{couterPassedCars} total cars passed the crossroads.");
        }
    }
}