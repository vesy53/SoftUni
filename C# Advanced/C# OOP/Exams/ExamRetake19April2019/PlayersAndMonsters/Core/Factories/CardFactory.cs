namespace PlayersAndMonsters.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using PlayersAndMonsters.IO;
    using PlayersAndMonsters.IO.Contracts;
    using PlayersAndMonsters.Models.Cards.Contracts;

    public class CardFactory : ICardFactory
    {
        private readonly IWriter writer;

        public CardFactory()
        {
            this.writer = new Writer();
        }

        public ICard CreateCard(string type, string name)
        {
            ICard card = null;

            try
            {
                Assembly assembly = Assembly
                    .GetCallingAssembly();

                Type classType = assembly
                    .GetTypes()
                    .FirstOrDefault(c => c.Name.StartsWith(type));

                card = (ICard)Activator
                    .CreateInstance(classType, name);
            }
            catch (TargetInvocationException tio)
            {
                this.writer.WriteLine(tio.InnerException.Message);
            }

            return card;
        }
    }
}
