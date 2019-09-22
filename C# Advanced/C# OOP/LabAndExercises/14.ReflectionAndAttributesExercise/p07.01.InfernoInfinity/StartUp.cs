namespace p07._01.InfernoInfinity
{
    using Microsoft.Extensions.DependencyInjection;
    using System;

    using Core;
    using Core.Commands;
    using Core.Commands.Contracts;
    using Core.Contracts;
    using Core.IO;
    using Core.IO.Contracts;
    using Data;
    using Data.Contracts;
    using Models.Gems.Contracts;
    using Models.Gems.Factories;
    using Models.Weapons.Contracts;
    using Models.Weapons.Factories;

    public class StartUp
    {
        public static void Main()
        {
            IServiceProvider serviceProvider = ConfigureServices();

            ICommandInterpreter commandInterpreter = 
                new CommandInterpreter(serviceProvider);

            IWriter writer = new ConsoleWriter();
            IReader reader = new ConsoleReader();

            IRunable engine = new Engine(
                commandInterpreter, 
                writer,
                reader);

            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IWeaponFactory, WeaponFactory>();
            services.AddTransient<IGemFactory, GemFactory>();
            services.AddTransient<IWriter, ConsoleWriter>();
            services.AddSingleton<IRepository, WeaponRepository>();

            IServiceProvider provider = services.BuildServiceProvider();

            return provider;
        }
    }
}
