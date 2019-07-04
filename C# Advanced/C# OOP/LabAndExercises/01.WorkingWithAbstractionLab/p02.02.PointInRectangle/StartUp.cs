namespace p02._02.PointInRectangle
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            double[] coordinatesOfTheRectangle = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());

            double topLeftX = coordinatesOfTheRectangle[0];
            double topLeftY = coordinatesOfTheRectangle[1];
            double bottomRightX = coordinatesOfTheRectangle[2];
            double bottomRightY = coordinatesOfTheRectangle[3];

            Point topLeftCorner = new Point(topLeftX, topLeftY);
            Point bottomRightCorner = new Point(bottomRightX, bottomRightY);

            Rectangle rectangle = new Rectangle(topLeftCorner, bottomRightCorner);

            for (int i = 0; i < number; i++)
            {
                double[] points = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                double pointX = points[0];
                double pointY = points[1];

                Point currentPoint = new Point(pointX, pointY);

                bool isInside = rectangle.Contains(currentPoint);

                Console.WriteLine(isInside);
            }
        }
    }
}
