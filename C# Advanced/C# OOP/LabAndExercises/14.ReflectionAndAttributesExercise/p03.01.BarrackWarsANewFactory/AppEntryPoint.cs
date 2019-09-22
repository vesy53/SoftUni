namespace p03._01.BarrackWarsANewFactory
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;

    public class AppEntryPoint
    {
        public static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
