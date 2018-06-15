using System;

namespace p06PointOnRectangleBorder
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
            bool border1 = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool border2 = (y == y1 || y == y2) && (x >= x1 && x <= x2);

            if (border1 || border2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
