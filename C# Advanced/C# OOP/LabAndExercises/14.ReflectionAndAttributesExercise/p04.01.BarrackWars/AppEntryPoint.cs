namespace p04._01.BarrackWars
{
    using Contracts;
    using Core;
    using Core.AllCommands;
    using Core.Factories;
    using Data;

    public class AppEntryPoint
    {
        public static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();

            ICommandInterpreter commandInterpreter =
                new CommandInterpreter(repository, unitFactory);

            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
