using System;

namespace p13PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool rec1 = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            bool rec2 = (x > h && x < 2 * h) && (y > h && y < 4 * h);

            bool insideBorder = (x > h && x < 2 * h) && y == h;
            bool onRightSide1 = x == 3 * h && (y >= 0 && y <= h);
            bool onLeftSide1 = x == 0 && (y >= 0 && y <= h);
            bool onBottom1 = (x >= 0 && x <= 3 * h) && y == 0;
            bool onTopSide1 = (x >= 0 && x <= h && y == h) ||
                (x >= 2 * h && x <= 3 * h && y == h);
            bool onRightSide2 = x == 2 * h && (y >= h && y <= 4 * h);
            bool onLeftSide2 = x == h && (y >= h && y <= 4 * h);
            bool onTopSide2 = (x >= h && x <= 2 * h) && y == 4 * h;


            if (rec1 || rec2 || insideBorder)
            {
                Console.WriteLine("inside");
            }
            else if (onRightSide1 || onLeftSide1 || onBottom1 || onTopSide1
                || onRightSide2 || onLeftSide2 || onTopSide2)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
