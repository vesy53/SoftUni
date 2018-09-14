using System;
using System.Linq;

class IntersectionOfCircles
{
    static void Main(string[] args)
    {
        double[] firstInput = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        double[] secondInput = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        Point firstPoint = new Point
        {
            X = firstInput[0],
            Y = firstInput[1]
        };

        Point secondPoint = new Point
        {
            X = secondInput[0],
            Y = secondInput[1]
        };

        double radius1 = firstInput[2];
        double radius2 = secondInput[2];

        Circle firstCircle = new Circle
        {
            Center = firstPoint,
            Radius = radius1
        };

        Circle secondCircle = new Circle
        {
            Center = secondPoint,
            Radius = radius2
        };

        bool isIntersect = IsIntersect(firstCircle, secondCircle);

        string result = isIntersect == true ?
            "Yes" :
            "No";

        Console.WriteLine(result);
    }

    static bool IsIntersect(Circle firstCircle, Circle secondCircle)
    {
        double distance = CalcDistrance(firstCircle.Center, secondCircle.Center);

        bool isIntersect = false;

        if (distance <= firstCircle.Radius + secondCircle.Radius)
        {
            isIntersect = true;
        }

        return isIntersect;
    }

    static double CalcDistrance(Point firstPoint, Point secondPoint)
    {
        double firstSide = Math.Pow((secondPoint.X - firstPoint.X), 2);
        double secondSide = Math.Pow((secondPoint.Y - firstPoint.Y), 2);

        double distance = Math.Sqrt(firstSide + secondSide);

        return distance;
    }
}

class Circle
{
    public Point Center { get; set; }

    public double Radius { get; set; }
}

class Point
{
    public double X { get; set; }

    public double Y { get; set; }
}