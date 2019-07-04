namespace p02._02.PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(Point topLeftCorner, Point bottomRightCorner)
        {
            this.TopLeftCorner = topLeftCorner;
            this.BottomRightCorner = bottomRightCorner;
        }

        public Point TopLeftCorner { get; private set; }

        public Point BottomRightCorner { get; private set; }

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
