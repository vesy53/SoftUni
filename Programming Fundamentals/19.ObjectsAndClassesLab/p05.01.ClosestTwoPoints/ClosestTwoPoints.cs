using System;
using System.Collections.Generic;
using System.Linq;

class ClosestTwoPoints
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        List<Point> points = new List<Point>();

        for (int i = 0; i < num; i++)
        {
            Point currentNums = ReadPoint();

            points.Add(currentNums);
        }

        double minDistance = double.MaxValue;
        Point minDistanceFirst = new Point();
        Point minDistanceSecond = new Point();

        for (int i = 0; i < points.Count; i++)
        {
            for (int j = i + 1; j < points.Count; j++)
            {
                double distance = CalcDistance(points[i], points[j]);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    minDistanceFirst = points[i];
                    minDistanceSecond = points[j];
                }
            }
        }

        Console.WriteLine($"{minDistance:F3}");
        Console.WriteLine($"({minDistanceFirst.X}, {minDistanceFirst.Y})");
        Console.WriteLine($"({minDistanceSecond.X}, {minDistanceSecond.Y})");
    }

    static double CalcDistance(Point point1, Point point2)
    {
        double sideA = Math.Pow((point1.X - point2.X), 2);
        double sideB = Math.Pow((point1.Y - point2.Y), 2);

        double result = Math.Sqrt(sideA + sideB);

        return result;
    }

    static Point ReadPoint()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Point numbers = new Point();

        numbers.X = arr[0];
        numbers.Y = arr[1];

        return numbers;
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}