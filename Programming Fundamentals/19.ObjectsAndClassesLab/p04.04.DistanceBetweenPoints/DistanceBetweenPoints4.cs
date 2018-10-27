using System;
using System.Linq;

class DistanceBetweenPoints4
{
    static void Main(string[] args)
    {
        Point firstPoint = Point.ParsePoint(Console.ReadLine());
        Point secondPoint = Point.ParsePoint(Console.ReadLine());

        double distance = CalcDistance(firstPoint, secondPoint);

        Console.WriteLine($"{distance:F3}");
    }

    static double CalcDistance(Point firstPoint, Point secondPoint)
    {
        double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
        double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

        return Math.Sqrt(sideA + sideB);
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int xCord, int yCord)
    {
        X = xCord;
        Y = yCord;
    }

    public static Point ParsePoint(string input)
    {
        int[] inputData = input
            .Split()
            .Select(int.Parse)
            .ToArray();

        return new Point(inputData[0], inputData[1]);
    }
}