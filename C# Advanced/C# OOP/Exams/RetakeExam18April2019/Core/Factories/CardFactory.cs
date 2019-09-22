namespace PlayersAndMonsters.Core.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    using Contracts;
    using PlayersAndMonsters.Models.Cards.Contracts;

    public class CardFactory : ICardFactory
    {
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
            catch (TargetInvocationException tie)
            {
                Console.WriteLine(tie.InnerException.Message);
            }

            return card;
        }
    }
}
