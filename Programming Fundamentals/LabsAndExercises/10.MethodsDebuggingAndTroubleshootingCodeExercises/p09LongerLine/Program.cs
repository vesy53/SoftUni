using System;

namespace p09LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double first = FindLongerLine(x1, y1, x2, y2);
            double second = FindLongerLine(x3, y3, x4, y4);

            if (first >= second)
            {
                FindClosestLine(x1, y1, x2, y2);
            }
            else
            {
                FindClosestLine(x3, y3, x4, y4);
            }
        }

        static double FindLongerLine(double x1, double y1, double x2, double y2)
        {
            double sum = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return sum;
        }

        static void FindClosestLine(double x1, double y1, double x2, double y2) 
        {
            double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }
    }
}
