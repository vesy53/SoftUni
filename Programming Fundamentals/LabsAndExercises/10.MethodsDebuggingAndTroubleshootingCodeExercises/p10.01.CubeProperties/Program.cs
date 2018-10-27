using System;

namespace p10CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = CubeProperties(sideCube, parameter);

            Console.WriteLine($"{result:F2}");
        }

        static double CubeProperties(double sideCube, string parameter)
        {
            double result = 0.0;

            switch (parameter)
            {
                case "face":
                    result = Math.Sqrt(2 * Math.Pow(sideCube, 2));
                    break;
                case "space":
                    result = Math.Sqrt(3 * Math.Pow(sideCube, 2));
                    break;
                case "volume":
                    result = Math.Pow(sideCube, 3);
                    break;
                case "area":
                    result = 6 * Math.Pow(sideCube, 2);
                    break;
            }

            return result;
        }
    }
}
