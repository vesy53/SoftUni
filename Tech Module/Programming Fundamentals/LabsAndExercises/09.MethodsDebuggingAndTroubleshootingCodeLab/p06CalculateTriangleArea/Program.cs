using System;

namespace p06CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalculateAreaTriangle(width, height);

            Console.WriteLine(area);
        }

        static double CalculateAreaTriangle(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
