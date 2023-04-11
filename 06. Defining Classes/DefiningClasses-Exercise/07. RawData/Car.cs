using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        public Car(string model,
            int speed,
            int power,
            int weight,
            string type, 
            double pressure1, int age1,
            double pressure2, int age2,
            double pressure3, int age3,
            double pressure4, int age4)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
            Tyres = new Tyre[4];
            Tyres[0] = new(pressure1, age1);
            Tyres[1] = new(pressure2, age2);
            Tyres[2] = new(pressure3, age3);
            Tyres[3] = new(pressure4, age4);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tyre[] Tyres { get; set; }
    }
}
