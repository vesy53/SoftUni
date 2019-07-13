namespace Shapes.Core
{
    using IO.Contracts;
    using Shapes.Models;
    using Shapes.Models.Contracts;

    public class Engine
    {
        private IReader reader;

        public Engine(IReader reader)
        {
            this.reader = reader;
        }

        public void Run()
        {
            int radius = int.Parse(reader.ConsoleReadLine());
            int width = int.Parse(reader.ConsoleReadLine());
            int height = int.Parse(reader.ConsoleReadLine());

            IDrawable circle = new Circle(radius);
            IDrawable rect = new Rectangle(width, height);

            circle.Draw();
            rect.Draw();
        }
    }
}
