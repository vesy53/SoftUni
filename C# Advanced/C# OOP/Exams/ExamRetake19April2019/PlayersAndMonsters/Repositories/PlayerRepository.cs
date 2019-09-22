namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.Players.Contracts;

    public class PlayerRepository : IPlayerRepository
    {
        private readonly List<IPlayer> players;

        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }

        public int Count => this.Players.Count;

        public IReadOnlyCollection<IPlayer> Players => 
            this.players.AsReadOnly();

        public void Add(IPlayer player)
        {
            NullPlayer(player);

            bool isExistPlayer = this.players
                .Any(p => p.Username == player.Username);

            if (isExistPlayer)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionMessages.ExistPlayer,
                        player.Username));
            }

            this.players.Add(player);
        }

        public IPlayer Find(string username)
        {
            return this.players
                .FirstOrDefault(p => p.Username == username);            
        }

        public bool Remove(IPlayer player)
        {
            NullPlayer(player);

            return this.players.Remove(player);
        }

        private static void NullPlayer(IPlayer player)
        {
            if (player is null)
            {
                throw new ArgumentException(
                    ExceptionMessages.InvalidPlayer);
            }
        }
    }
}
