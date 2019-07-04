namespace p02._01.PointInRectangle
{
    using System;
    using System.Linq;

    public class Rectangle
    {
        public Point TopLeftCorner { get; private set; }

        public Point BottomRightCorner { get;  private set; }

        public Rectangle(string input)
        {
            int[] coordinates = input
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int topLeftX = coordinates[0];
            int topLeftY = coordinates[1];
            int bottomRightX = coordinates[2];
            int bottomRightY = coordinates[3];

            this.TopLeftCorner = new Point(topLeftX, topLeftY);
            this.BottomRightCorner = new Point(bottomRightX, bottomRightY);
        }

        public bool Contains(Point point)
        {
            bool isInsideX =
                point.PointX >= TopLeftCorner.PointX &&
                point.PointX <= BottomRightCorner.PointX;

            bool isInsideY =
                point.PointY >= TopLeftCorner.PointY &&
                point.PointY <= BottomRightCorner.PointY;

            return isInsideX && isInsideY;
        }
    }
}
