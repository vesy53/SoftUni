using System;
using System.Linq;

class DistanceBetweenPoints
{
    static void Main(string[] args)
    {
        Point p1 = ReadPoint();
        Point p2 = ReadPoint();

        double distance = CalcDistance(p1, p2);

        Console.WriteLine($"{distance:F3}");
    }

    static double CalcDistance(Point p1, Point p2)
    {
        int xPoint = p2.X - p1.X;
        int yPoint = p2.Y - p1.Y;

        return Math.Sqrt(xPoint * xPoint + yPoint * yPoint);
    }

    static Point ReadPoint()
    {
        int[] pointNums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Point point = new Point();

        point.X = pointNums[0];
        point.Y = pointNums[1];

        return point;
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}