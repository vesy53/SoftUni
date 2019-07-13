namespace p02._01.ClassBoxDataValidation
{
    using Core;
    using Core.IO;
    using Core.IO.Contracts;

    public class StartUp
    {
        private static void Main()
        {
            IReader reader = new ConsoleRead();
            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
