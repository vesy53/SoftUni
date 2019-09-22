namespace MortalEngines
{
    using Core;
    using Core.Contracts;
    using IO;
    using IO.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();

            IMachinesManager machinesManager = new MachinesManager();

            ICommandInterpreter commandInterpreter = new CommandInterpreter(machinesManager);

            IEngine engine = new Engine(reader, writer, commandInterpreter);
            engine.Run();
        }
    }
}