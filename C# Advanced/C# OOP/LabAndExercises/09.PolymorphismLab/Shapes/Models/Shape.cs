namespace Shapes.Models
{
    using Shapes.Contracts;

    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public virtual string Draw()
        {
            return "Drawing ";
        }
    }
}
