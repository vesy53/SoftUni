using System;
using System.Collections.Generic;
using System.Linq;

class ClosestTwoPoints3
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        List<Point> points = new List<Point>();

        for (int i = 0; i < num; i++)
        {
            Point currentNums = Point.ParsePoint(Console.ReadLine());

            points.Add(currentNums);
        }

        double minDistance = double.MaxValue;
        Point[] bestPoints = new Point[2];

        for (int i = 0; i < points.Count; i++)
        {
            for (int j = i + 1; j < points.Count; j++)
            {
                double distance = CalcDistance(points[i], points[j]);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    bestPoints[0] = points[i];
                    bestPoints[1] = points[j];
                }
            }
        }

        Console.WriteLine($"{minDistance:F3}");
        Console.WriteLine(bestPoints[0]);
        Console.WriteLine(bestPoints[1]);
    }

    static double CalcDistance(Point point1, Point point2)
    {
        double side1 = Math.Pow((point1.X - point2.X), 2);
        double side2 = Math.Pow((point1.Y - point2.Y), 2);

        return Math.Sqrt(side1 + side2);
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

    public override string ToString()
    {
        return String.Format($"({X}, {Y})");
    }
}