namespace p09._01.RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double coordinateTopLeftX;
        private double coordinateTopLeftY;

        public Rectangle(
            string id, 
            double width, 
            double height, 
            double coordinateTopLeftX, 
            double coordinateTopLeftY)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.CoordinateTopLeftX = coordinateTopLeftX;
            this.CoordinateTopLeftY = coordinateTopLeftY;
        }

        public string Id
        {
            get => this.id;
            set => this.id = value;
        }

        public double Width
        {
            get => this.width;
            set => this.width = value;
        }

        public double Height
        {
            get => this.height;
            set => this.height = value;
        }

        public double CoordinateTopLeftX
        {
            get => this.coordinateTopLeftX;
            set => this.coordinateTopLeftX = value;
        }

        public double CoordinateTopLeftY
        {
            get => this.coordinateTopLeftY;
            set => this.coordinateTopLeftY = value;
        }

        public bool Intersect(Rectangle secondRectangle)
        {
            if (this.CoordinateTopLeftX + this.Width >= secondRectangle.CoordinateTopLeftX &&
                secondRectangle.CoordinateTopLeftX + secondRectangle.Width >= this.CoordinateTopLeftX &&
                this.CoordinateTopLeftY + this.Height >= secondRectangle.CoordinateTopLeftY &&
                secondRectangle.CoordinateTopLeftY + secondRectangle.Height >= this.CoordinateTopLeftY)
            {
                return true;
            }

            return false;
        }
    }
}
