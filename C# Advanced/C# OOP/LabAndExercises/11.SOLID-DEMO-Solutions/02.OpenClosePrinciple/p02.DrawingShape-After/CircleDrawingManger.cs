namespace p02.DrawingShape_After
{
    using Contracts;

    public class CircleDrawingManger : DrawingManager
    {
        protected override void DrawFigure(IShape shape)
        {
            var circle = shape as Circle;

            // Draw Circle
        }
    }
}
