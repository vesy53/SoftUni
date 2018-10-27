using System;
using System.Linq;

class DistanceBetweenPoints2
{
    static void Main(string[] args)
    {
        int[] firstRow = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[] secondRow = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Point firstP1 = new Point { X = firstRow[0], Y = firstRow[1] };
        Point secondP2 = new Point { X = secondRow[0], Y = secondRow[1] };

        double distance = CalcDistance(firstP1, secondP2);

        Console.WriteLine("{0:f3}", distance);
    }

    static double CalcDistance(Point firstP1, Point secondP2)
    {
        double sideA = firstP1.X - secondP2.X;
        double sideB = firstP1.Y - secondP2.Y;

        double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

        return distance;
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

