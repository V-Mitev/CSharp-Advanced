using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                double pressure1 = double.Parse(input[5]);
                int age1 = int.Parse(input[6]);
                double pressure2 = double.Parse(input[7]);
                int age2 = int.Parse(input[8]);
                double pressure3 = double.Parse(input[9]);
                int age3 = int.Parse(input[10]);
                double pressure4 = double.Parse(input[11]);
                int age4 = int.Parse(input[12]);

                Car car = new Car(model, speed, power, weight, type, pressure1, age1, pressure2, age2, pressure3, age3, pressure4, age4);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            string[] filteredCarModels;

            if (command == "fragile")
            {
                filteredCarModels = cars
                .Where(c => c.Cargo.Type == "fragile" && c.Tyres.Any(t => t.Pressure < 1))
                .Select(c => c.Model)
                .ToArray();
            }
            else
            {
                filteredCarModels = cars
                .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                .Select(c => c.Model)
                .ToArray();
            }

            Console.WriteLine(string.Join(Environment.NewLine, filteredCarModels));
        }
    }
}