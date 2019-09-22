namespace PlayersAndMonsters.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using PlayersAndMonsters.IO;
    using PlayersAndMonsters.IO.Contracts;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;

    public class PlayerFactory : IPlayerFactory
    {
        private readonly IWriter writer;

        public PlayerFactory()
        {
            this.writer = new Writer();
        }

        public IPlayer CreatePlayer(string type, string username)
        {
            IPlayer player = null;

            try
            {
                Assembly assembly = Assembly
                    .GetCallingAssembly();

                Type classType = assembly
                    .GetTypes()
                    .FirstOrDefault(c => c.Name == type);

                player = (IPlayer)Activator
                    .CreateInstance(classType, new CardRepository(), username);
            }
            catch (TargetInvocationException tio)
            {
                this.writer.WriteLine(tio.InnerException.Message);
            }

            return player;
        }
    }
}
