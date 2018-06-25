using System;

namespace p10CubeProperties2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    double faceDiagonals = CalculateCubeFace(sideCube, parameter);
                    PrintCubeParameter(faceDiagonals);
                    break;
                case "space":
                    double spaceDiagonals = CalculateCubeSpace(sideCube, parameter);
                    PrintCubeParameter(spaceDiagonals);
                    break;
                case "volume":
                    double volume = CalculateCubeVolume(sideCube, parameter);
                    PrintCubeParameter(volume);
                    break;
                case "area":
                    double area = CalculateCubeArea(sideCube, parameter);
                    PrintCubeParameter(area);
                    break;
            }         
        }

        static void PrintCubeParameter(double result)
        {
            Console.WriteLine($"{result:F2}");
        }

        static double CalculateCubeFace(double side, string parameter)
        {
            double faceDiagonals = Math.Sqrt(2 * Math.Pow(side, 2));
            return faceDiagonals;
        }

        static double CalculateCubeSpace(double side, string parameter)
        {
            double spaceDiagonals = Math.Sqrt(3 * Math.Pow(side, 2));
            return spaceDiagonals;
        }

        static double CalculateCubeVolume(double side, string parameter)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }

        static double CalculateCubeArea(double side, string parameter)
        {
            double area = 6 * Math.Pow(side, 2);
            return area;
        }
    }
}

