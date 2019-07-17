namespace p02._01.StreamProgress
{
    using System;

    public class Program
    {
        public static void Main()
        {
            IShape circle = new Circle();
            IShape rectangle = new Rectangle();
            IShape square = new Square();

            GraphicEditor graphic = new GraphicEditor();

            graphic.DrawShape(circle);
            graphic.DrawShape(rectangle);
            graphic.DrawShape(square);
        }
    }
}
