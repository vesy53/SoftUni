using System;
using System.Collections.Generic;

class Boxes
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<Box> boxesList = new List<Box>();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { " | ", ":" },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            List<Point> pointsList = new List<Point>();

            for (int i = 0; i < inputTokens.Length - 1; i += 2)
            {
                int numX = int.Parse(inputTokens[i]);
                int numY = int.Parse(inputTokens[i + 1]);

                Point point = new Point
                {
                    X = numX,
                    Y = numY
                };

                pointsList.Add(point);
            }

            Box box = new Box
            {
                UpperLeft = pointsList[0],
                UpperRight = pointsList[1],
                BottomLeft = pointsList[2],
                BottomRight = pointsList[3]
            };

            boxesList.Add(box);

            input = Console.ReadLine();
        }

        foreach (Box box in boxesList)
        {
            Point upperLeft = box.UpperLeft;
            Point upperRight = box.UpperRight;
            Point bottomLeft = box.BottomLeft;

            int width = Point.CalcDistance(upperRight, upperLeft);
            int height = Point.CalcDistance(upperLeft, bottomLeft);

            int perimeter = Box.CalculatePerimeter(width, height);
            int area = Box.CalculateArea(width, height);

            Console.WriteLine($"Box: {width}, {height}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Area: {area}");
        }
    }
}

class Box
{
    public Point UpperLeft { get; set; }
    public Point UpperRight { get; set; }
    public Point BottomLeft { get; set; }
    public Point BottomRight { get; set; }

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
    public int X { get; set; }
    public int Y { get; set; }

    public static int CalcDistance(Point firstPoint, Point seconPoint)
    {
        double sideA = Math.Pow((firstPoint.X - seconPoint.X), 2);
        double sideB = Math.Pow((firstPoint.Y - seconPoint.Y), 2);

        int distance = (int)Math.Sqrt(sideA + sideB);

        return distance;
    }
}