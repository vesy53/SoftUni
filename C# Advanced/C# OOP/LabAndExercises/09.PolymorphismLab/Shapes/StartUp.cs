namespace Shapes
{
    using System;

    using Contracts;
    using Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IShape rectangle = new Rectangle(4.5, 2.9);
            IShape circle = new Circle(8.2);

            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());

            Console.WriteLine(circle.Draw());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
        }
    }
}
