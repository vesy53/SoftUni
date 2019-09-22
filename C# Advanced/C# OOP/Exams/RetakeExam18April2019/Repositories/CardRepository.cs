namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.Cards.Contracts;

    public class CardRepository : ICardRepository
    {
        private readonly List<ICard> cards;

        public CardRepository()
        {
            this.cards = new List<ICard>();
        }
        
        public int Count => this.Cards.Count;

        public IReadOnlyCollection<ICard> Cards => 
            this.cards.AsReadOnly();

        public void Add(ICard card)
        {
            NullCard(card);

            if (this.cards.Any(c => c.Name == card.Name))
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.ExistCardName,
                        card.Name));
            }

            this.cards.Add(card);
        }

        public ICard Find(string name)
        {
            ICard card = this.cards
                .FirstOrDefault(c => c.Name == name);

            return card;
        }

        public bool Remove(ICard card)
        {
            NullCard(card);

            return this.cards.Remove(card);
        }

        private static void NullCard(ICard card)
        {
            if (card is null)
            {
                throw new ArgumentException(
                    ExceptionMessages.InvalidCard);
            }
        }
    }
}
