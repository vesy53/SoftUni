using System;

namespace p08MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputCurrent = Console.ReadLine();
            string outputCurrent = Console.ReadLine();

            double total = 0.0;

            if (inputCurrent == "m")
            {
                total = number;
            }
            else if (inputCurrent == "mm")
            {
                total = number / 1000;
            }
            else if (inputCurrent == "cm")
            {
                total = number / 100;
            }
            else if (inputCurrent == "mi")
            {
                total = number / 0.000621371192;
            }
            else if (inputCurrent == "in")
            {
                total = number / 39.3700787;
            }
            else if (inputCurrent == "km")
            {
                total = number / 0.001;
            }
            else if (inputCurrent == "ft")
            {
                total = number / 3.2808399;
            }
            else if (inputCurrent == "yd")
            {
                total = number / 1.0936133;
            }

            if (outputCurrent == "m")
            {
                total *= 1;
            }
            else if (outputCurrent == "mm")
            {
                total *= 1000;
            }
            else if (outputCurrent == "cm")
            {
                total *= 100;
            }
            else if (outputCurrent == "mi")
            {
                total *= 0.000621371192;
            }
            else if (outputCurrent == "in")
            {
                total *= 39.3700787;
            }
            else if (outputCurrent == "km")
            {
                total *= 0.001;
            }
            else if (outputCurrent == "ft")
            {
                total *= 3.2808399;
            }
            else if (outputCurrent == "yd")
            {
                total *= 1.0936133;
            }

            Console.WriteLine($"{total:F8}");
        }
    }
}
