﻿namespace p08._01.RawData
{
    public class Tire
    {
        public Tire(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }

        public int Age { get; set; }

        public double Pressure { get; set; }
    }
}
