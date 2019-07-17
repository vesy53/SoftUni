namespace p01.Square_After
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public override double Area => this.Width * this.Height;
    }
}
