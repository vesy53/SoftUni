using System;

namespace p03PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool difX = x1 < x2;
            bool difY = y1 < y2;
            bool rightSide = x >= x1;
            bool leftSide = x <= x2;
            bool bottomSide = y >= y1;
            bool topSide = y <= y2;

            if (rightSide && leftSide && bottomSide && topSide)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
