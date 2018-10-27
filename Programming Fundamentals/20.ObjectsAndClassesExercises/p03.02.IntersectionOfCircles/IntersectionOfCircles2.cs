using System;
using System.Linq;

class IntersectionOfCircles2
{
    static void Main(string[] args)
    {
        Circle firstCircle = ReadCircle();
        Circle secondCircle = ReadCircle();

        bool isIntersect = IsIntersect(firstCircle, secondCircle);

        if (isIntersect)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
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

    static double CalcDistrance(Point firstCircle, Point secondCircle)
    {
        double firstSide = Math.Pow((firstCircle.X - firstCircle.X), 2);
        double secondSide = Math.Pow((secondCircle.Y - secondCircle.Y), 2);

        double distance = Math.Sqrt(firstSide + secondSide);

        return distance;
    }

    static Circle ReadCircle()
    {
        double[] input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        Point arguments = new Point
        {
            X = input[0],
            Y = input[1]
        };

        double radius = input[2];

        Circle circleArgs = new Circle
        {
            Center = arguments,
            Radius = radius
        };

        return circleArgs;
    }
}

class Circle
{
    public Point Center;
    public double Radius { get; set; }
}

class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}