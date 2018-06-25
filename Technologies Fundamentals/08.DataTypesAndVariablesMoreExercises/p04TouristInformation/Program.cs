using System;

namespace p04TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string innerUints = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            double convertedSum = 0.0;
            string outerUints = "";

            switch (innerUints)
            {
                case "miles":
                    convertedSum = value * 1.6;
                    outerUints = "kilometers";
                    break;
                case "inches":
                    convertedSum = value * 2.54;
                    outerUints = "centimeters";
                    break;
                case "feet":
                    convertedSum = value * 30;
                    outerUints = "centimeters";
                    break;
                case "yards":
                    convertedSum = value * 0.91;
                    outerUints = "meters";
                    break;
                case "gallons":
                    convertedSum = value * 3.8;
                    outerUints = "liters";
                    break;
            }

            Console.WriteLine(
                $"{value} {innerUints} = {convertedSum:F2} {outerUints}");
        }
    }
}
