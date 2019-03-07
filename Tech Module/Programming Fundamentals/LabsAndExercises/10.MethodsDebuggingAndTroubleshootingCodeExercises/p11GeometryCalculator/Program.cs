using System;

namespace p11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeGeometryFig = Console.ReadLine();

            double area = 0.0;

            switch (typeGeometryFig)
            {
                case "triangle":
                    area = CalculateTriangleArea(typeGeometryFig);
                    break;
                case "square":
                    area = CalculateSquareArea(typeGeometryFig);
                    break;
                case "rectangle":
                    area = CalculateRectangleArea(typeGeometryFig);
                    break;
                case "circle":
                    area = CalculateCircleArea(typeGeometryFig);
                    break;
            }

            Console.WriteLine($"{area:F2}");
        }

        static double CalculateTriangleArea(string typeGeometryFig)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height / 2;

            return area;
        }

        static double CalculateSquareArea(string typeGeometryFig)
        {
            double side = double.Parse(Console.ReadLine());

            double area = side * side;

            return area;
        }

        static double CalculateRectangleArea(string typeGeometryFig)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;

            return area;
        }

        static double CalculateCircleArea(string typeGeometryFig)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            return area;
        }
    }
}
