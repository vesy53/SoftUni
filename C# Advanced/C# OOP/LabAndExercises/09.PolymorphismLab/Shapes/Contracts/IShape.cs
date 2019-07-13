namespace Shapes.Contracts
{
    public interface IShape
    {
        double CalculatePerimeter();

        double CalculateArea();

        string Draw();
    }
}
