using System;

namespace p10CubeProperties1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = 0.0;

            switch (parameter)
            {
                case "face":
                    result = CalculateCubeFace(sideCube, parameter);
                    break;
                case "space":
                    result = CalculateCubeSpace(sideCube, parameter);
                    break;
                case "volume":
                    result = CalculateCubeVolume(sideCube, parameter);
                    break;
                case "area":
                    result = CalculateCubeArea(sideCube, parameter);
                    break;
            }

            Console.WriteLine($"{result:F2}");
        }

        static double CalculateCubeFace(double side, string parameter)
        {
            double result = Math.Sqrt(2 * Math.Pow(side, 2));
            return result;
        }

        static double CalculateCubeSpace(double side, string parameter)
        {
            double result = Math.Sqrt(3 * Math.Pow(side, 2));
            return result;
        }

        static double CalculateCubeVolume(double side, string parameter)
        {
            double result = Math.Pow(side, 3);
            return result;
        }

        static double CalculateCubeArea(double side, string parameter)
        {
            double result = 6 * Math.Pow(side, 2);
            return result;
        }
    }
}
