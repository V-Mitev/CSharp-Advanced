﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tyre
    {
        public Tyre(double pressure, int age)
        {
            Age = age;
            Pressure = pressure;
        }
        
        public int Age { get; set; }
        public double Pressure { get; set; }
    }
}
