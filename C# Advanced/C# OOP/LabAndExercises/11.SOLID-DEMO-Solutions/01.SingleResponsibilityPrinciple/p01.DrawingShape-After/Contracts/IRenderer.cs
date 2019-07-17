namespace p01.DrawingShape_After.Contracts
{
    public interface IRenderer
    {
        void Render(IDrawingContext drawingContext, IShape shape);
    }
}
