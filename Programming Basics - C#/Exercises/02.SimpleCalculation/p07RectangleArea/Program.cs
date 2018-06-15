using System;

namespace p072DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double side1 = Math.Max(x1, x2) - Math.Min(x1, x2);
            double side2 = Math.Max(y1, y2) - Math.Min(y1, y2);

            double area = side1 * side2;
            double perimeter = 2 * (side1 + side2);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
