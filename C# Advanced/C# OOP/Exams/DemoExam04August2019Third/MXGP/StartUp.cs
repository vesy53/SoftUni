namespace MXGP
{
    using Models.Motorcycles;
    using Core;
    using Core.Contracts;
    using IO;
    using IO.Contracts;
    using Repositories;
    using Core.Factories.Contracts;
    using Core.Factories;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //TODO Add IEngine
            //Motorcycle varche = new PowerMotorcycle("12214235", 75);
            //Console.WriteLine(varche.HorsePower);
            IMotorcycleFactory motorcycleFactory = new MotorcycleFactory();
            IRaceFactory raceFactory = new RaceFactory();
            IRiderFactory riderFactory = new RiderFactory();

            MotorcycleRepository motorcycleRepository = new MotorcycleRepository();
            RaceRepository raceRepository = new RaceRepository();
            RiderRepository riderRepository = new RiderRepository();

            IChampionshipController controller = new ChampionshipController(
                motorcycleFactory,
                raceFactory,
                riderFactory,
                motorcycleRepository,
                raceRepository,
                riderRepository);

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer, controller);
            engine.Run();
        }
    }
}
