namespace p02._01.PointInRectangle
{
    using System;
    using System.Linq;

    public class Point
    {
        public int PointX { get; private set; }

        public int PointY { get; private set; }

        public Point(int x, int y)
        {
            this.PointX = x;
            this.PointY = y;
        }

        public Point(string input)
        {
            int[] coordinates = input
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            PointX = coordinates[0];
            PointY = coordinates[1];
        }
    }
}
