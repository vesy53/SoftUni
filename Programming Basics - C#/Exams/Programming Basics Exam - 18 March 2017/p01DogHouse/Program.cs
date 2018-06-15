using System;

namespace p01DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthSide = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double totalWidth = widthSide * (widthSide / 2) * 2;
            double square = widthSide / 2 * widthSide / 2;
            double triangle = (widthSide / 2 * (height - widthSide / 2)) / 2;
            double rearWall = square + triangle;
            double door = widthSide / 5 * widthSide / 5;
            double frontWall = rearWall - door;
            double total = totalWidth + rearWall + frontWall;
            double greenPaint = total / 3;
            double roof = widthSide * (widthSide / 2) * 2;
            double redPaint = roof / 5;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
