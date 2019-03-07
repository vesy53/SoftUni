using System;
using System.Linq;

class DistanceBetweenPoints3
{
    static void Main(string[] args)
    {
        Point firstPoint = ReadPoint();
        Point secondPoint = ReadPoint();

        double distance = CalcDistance(firstPoint, secondPoint);

        Console.WriteLine($"{distance:f3}");
    }

    static double CalcDistance(Point firstPoint, Point secondPoint)
    {
        double result = Math.Sqrt(
            Math.Pow(
                firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2)
         );

        return result;
    }

    static Point ReadPoint()
    {
        int[] points = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        return new Point
        {
            X = points[0],
            Y = points[1]
        };
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
