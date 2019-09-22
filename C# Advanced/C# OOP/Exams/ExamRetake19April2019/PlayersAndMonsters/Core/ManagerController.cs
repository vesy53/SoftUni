namespace PlayersAndMonsters.Core
{
    using System.Text;

    using Contracts;
    using Factories;
    using Factories.Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.BattleFields;
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;
    using PlayersAndMonsters.Repositories.Contracts;

    public class ManagerController : IManagerController
    {
        private readonly IPlayerFactory playerFactory;
        private readonly ICardFactory cardFactory;

        private readonly IPlayerRepository playerRepository;
        private readonly ICardRepository cardRepository;

        private readonly IBattleField battleField;

        public ManagerController()
        {
            this.playerFactory = new PlayerFactory();
            this.cardFactory = new CardFactory();

            this.playerRepository = new PlayerRepository();
            this.cardRepository = new CardRepository();

            this.battleField = new BattleField();
        }

        public string AddPlayer(string type, string username)
        {
            IPlayer player = this.playerFactory
                .CreatePlayer(type, username);

            this.playerRepository.Add(player);

            return string.Format(
                ConstantMessages.SuccessfullyAddedPlayer,
                player.GetType().Name,
                player.Username);
        }

        public string AddCard(string type, string name)
        {
            ICard card = this.cardFactory
                .CreateCard(type, name);

            this.cardRepository.Add(card);

            return string.Format(
                ConstantMessages.SuccessfullyAddedCard,
                type,
                card.Name);
        }

        public string AddPlayerCard(string username, string cardName)
        {
            IPlayer player = this.playerRepository
                .Find(username);

            ICard card = this.cardRepository
                .Find(cardName);

            player.CardRepository.Add(card);

            return string.Format(
                ConstantMessages.SuccessfullyAddedPlayerWithCards,
                card.Name,
                player.Username);
        }

        public string Fight(string attackUser, string enemyUser)
        {
            IPlayer attacker = this.playerRepository
                .Find(attackUser);
            IPlayer enemy = this.playerRepository
                .Find(enemyUser);

            this.battleField.Fight(attacker, enemy);

            return string.Format(
                ConstantMessages.FightInfo,
                attacker.Health,
                enemy.Health);
        }

        public string Report()
        {
            StringBuilder builder = new StringBuilder();

            foreach (IPlayer playerInfo in this.playerRepository
                .Players)
            {
                builder.AppendLine(playerInfo.ToString());

                foreach (ICard cardInfo in playerInfo
                    .CardRepository
                    .Cards)
                {
                    builder.AppendLine(cardInfo.ToString());
                }

                builder.AppendLine(
                    ConstantMessages.DefaultReportSeparator);
            }

            return builder.ToString().TrimEnd();
        }
    }
}
