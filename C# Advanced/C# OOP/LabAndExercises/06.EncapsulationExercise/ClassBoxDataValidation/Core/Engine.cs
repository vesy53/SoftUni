namespace p02._01.ClassBoxDataValidation.Core
{
    using System;

    using IO.Contracts;

    public class Engine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            try
            {
                double length = double.Parse(reader.ConsoleReadLine());
                double width = double.Parse(reader.ConsoleReadLine());
                double height = double.Parse(reader.ConsoleReadLine());

                Box box = new Box(length, width, height);

                writer.ConsoleWriteLine(box.ToString());
            }
            catch (Exception ex)
            {
                writer.ConsoleWriteLine(ex.Message);
            }
        }
    }
}
