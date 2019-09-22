namespace p06._01.TrafficLights
{
    using Core;
    using Core.IO;
    using Core.IO.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IRead read = new Read();
            IWriter writer = new Write();
            IWriteLine writeLine = new WriteLine();

            Engine engine = new Engine(read, writer, writeLine);
            engine.Run();
        }
    }
}
