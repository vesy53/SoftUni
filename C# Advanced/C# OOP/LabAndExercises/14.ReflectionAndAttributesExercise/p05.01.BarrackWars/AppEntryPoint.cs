namespace p05._01.BarrackWars
{
    using Microsoft.Extensions.DependencyInjection;
    using System;

    using Contracts;
    using Core;
    using Core.AllCommands;
    using Core.Factories;
    using Data;

    public class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IServiceProvider provider = ConfigureServices();

            ICommandInterpreter commandInterpreter = 
                new CommandInterpreter(provider);

            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection service = new ServiceCollection();

            service.AddTransient<IUnitFactory, UnitFactory>();
            service.AddSingleton<IRepository, UnitRepository>();

            IServiceProvider serviceProvider = service
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
