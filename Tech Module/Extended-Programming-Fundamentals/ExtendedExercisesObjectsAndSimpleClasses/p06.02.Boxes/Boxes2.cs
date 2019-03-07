using System;
using System.Collections.Generic;
using System.Linq;

class Boxes2
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<Box> boxesList = new List<Box>();

        while (input != "end")
        {
            int[] inputTokens = input
                .Split(new string[] { " | ", ":" },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            Point upperLeft = new Point
            {
                X = inputTokens[0],
                Y = inputTokens[1]
            };

            Point upperRight = new Point
            {
                X = inputTokens[2],
                Y = inputTokens[3]
            };

            Point bottomLeft = new Point
            {
                X = inputTokens[4],
                Y = inputTokens[5]
            };

            Point bottomRight = new Point
            {
                X = inputTokens[6],
                Y = inputTokens[7]
            };

            int width = Point.CalDistance(upperLeft, upperRight);
            int hight = Point.CalDistance(upperLeft, bottomLeft);
            int perimeter = Box.CalculatePerimeter(width, hight);
            int area = Box.CalculateArea(width, hight);

            Box box = new Box
            {
                Height = hight,
                Width = width,
                Area = area,
                Perimeter = perimeter
            };

            boxesList.Add(box);

            input = Console.ReadLine();
        }

        foreach (var box in boxesList)
        {
            int width = box.Width;
            int height = box.Height;
            int perimeter = box.Perimeter;
            int area = box.Area;

            Console.WriteLine($"Box: {width}, {height}");
            Console.WriteLine($"Perimeter: {box.Perimeter}");
            Console.WriteLine($"Area: {area}");
        }
    }
}

class Box
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int Perimeter { get; set; }
    public int Area { get; set; }

    public static int CalculatePerimeter(int width, int height)
    {
        return 2 * (width + height);
    }

    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }
}

class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public static int CalDistance(Point firstPoint, Point seconPoint)
    {
        double sideA = Math.Pow((firstPoint.X - seconPoint.X), 2);
        double sideB = Math.Pow((firstPoint.Y - seconPoint.Y), 2);

        int distance = (int)Math.Sqrt(sideA + sideB);

        return distance;
    }
}