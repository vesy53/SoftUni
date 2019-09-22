namespace PlayersAndMonsters.Models.BattleFields
{
    using System;
    using System.Linq;

    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;

    public class BattleField : IBattleField
    {
        private const int IncreaseHealthPoints = 40;
        private const int IncreaseDamagePoints = 30;

        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead ||
                enemyPlayer.IsDead)
            {
                throw new ArgumentException(
                    ExceptionMessages.DeadPlayer);
            }

            if (attackPlayer.GetType() == typeof(Beginner))
            {
                attackPlayer.Health += IncreaseHealthPoints;

                attackPlayer.CardRepository
                            .Cards
                            .ToList()
                            .ForEach(c => c.DamagePoints += IncreaseDamagePoints);
            }

            if (enemyPlayer.GetType().Name == nameof(Beginner))
            {
                enemyPlayer.Health += IncreaseHealthPoints;

                enemyPlayer.CardRepository
                           .Cards
                           .ToList()
                           .ForEach(c => c.DamagePoints += IncreaseDamagePoints);
            }

            attackPlayer.Health += attackPlayer
                .CardRepository
                .Cards
                .Sum(c => c.HealthPoints);
            enemyPlayer.Health += enemyPlayer
                .CardRepository
                .Cards
                .Sum(c => c.HealthPoints);

            while (true)
            {
                int attackerDamagePoints = attackPlayer
                    .CardRepository
                    .Cards
                    .Sum(c => c.DamagePoints);

                enemyPlayer.TakeDamage(attackerDamagePoints);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                int enemyDamagePoints = enemyPlayer
                    .CardRepository
                    .Cards
                    .Sum(c => c.DamagePoints);

                attackPlayer.TakeDamage(enemyDamagePoints);

                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }
    }
}
