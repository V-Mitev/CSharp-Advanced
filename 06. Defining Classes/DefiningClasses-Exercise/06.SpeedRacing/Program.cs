using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);

                Car car = new Car(make, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = cmdArgs[1];
                double amountOfKm = double.Parse(cmdArgs[2]);

                Car carToDrive = cars.First(car => car.Model == carModel);

                carToDrive.Drive(amountOfKm);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}