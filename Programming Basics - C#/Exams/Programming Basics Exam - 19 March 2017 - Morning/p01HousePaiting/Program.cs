using System;

namespace p01HousePaiting
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightHouse = double.Parse(Console.ReadLine());
            double widthSide = double.Parse(Console.ReadLine());
            double heightTriangWall = double.Parse(Console.ReadLine());

            double totalSide = heightHouse * widthSide;
            double window = 1.5 * 1.5;
            double twoTotalSide = 2 * totalSide - 2 * window;
            double rearWall = heightHouse * heightHouse;
            double door = 1.2 * 2;
            double totalWall = 2 * rearWall - door;
            double total = twoTotalSide + totalWall;
            double greenPaint = total / 3.4;

            double twoRectanglesRoof = 2 * heightHouse * widthSide;
            double twoTrianglesRoof = 2 * (heightHouse * heightTriangWall) / 2;
            double totalRoof = twoRectanglesRoof + twoTrianglesRoof;
            double redPaint = totalRoof / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
