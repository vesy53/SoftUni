using System;
using System.Collections.Generic;
using System.Linq;

class ClosestTwoPoints2
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        List<Point> points = new List<Point>();

        for (int i = 0; i < num; i++)
        {
            Point currentNums = ReadPoints();

            points.Add(currentNums);
        }

        double minDistance = double.MaxValue;
        Point[] bestPoint = new Point[2];

        for (int i = 0; i < points.Count; i++)
        {
            for (int j = i + 1; j < points.Count; j++)
            {
                double distance = CalcDistance(points[i], points[j]);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    bestPoint[0] = points[i];
                    bestPoint[1] = points[j];
                }
            }
        }

        Console.WriteLine($"{minDistance:f3}");
        Console.WriteLine(bestPoint[0]);
        Console.WriteLine(bestPoint[1]);
    }

    static double CalcDistance(Point point1, Point point2)
    {
        double firstSide = Math.Pow(point1.X - point2.X, 2);
        double secondSide = Math.Pow(point1.Y - point2.Y, 2);

        return Math.Sqrt(firstSide + secondSide);
    }

    private static Point ReadPoints()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Point numbers = new Point
        {
            X = arr[0],
            Y = arr[1]
        };

        return numbers;
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return String.Format($"({X}, {Y})");
    }
}