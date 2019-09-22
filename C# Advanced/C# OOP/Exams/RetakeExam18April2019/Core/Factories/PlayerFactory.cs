namespace PlayersAndMonsters.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;

    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            IPlayer player = null;

            try
            {
                Assembly assembly = Assembly
                    .GetCallingAssembly();

                Type classType = assembly
                    .GetTypes()
                    .First(t => t.Name == type);

                object[] paramsObject = new object[]
                {
                    new CardRepository(),
                    username
                };

                player = (IPlayer)Activator
                    .CreateInstance(classType, paramsObject);
            }
            catch (TargetInvocationException tie)
            {
                Console.WriteLine(tie.InnerException.Message);
            }

            return player;
        }
    }
}
