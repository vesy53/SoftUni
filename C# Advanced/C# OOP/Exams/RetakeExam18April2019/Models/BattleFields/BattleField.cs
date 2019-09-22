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
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException(
                    ExceptionMessages.DeadPlayer);
            }

            if (attackPlayer is Beginner)
            {
                attackPlayer.Health += IncreaseHealthPoints;

                //foreach (ICard cardInfo in attackPlayer.CardRepository.Cards)
                //{
                //    cardInfo.DamagePoints += IncreaseDamagePoints;
                //}

                attackPlayer.CardRepository
                            .Cards
                            .ToList()
                            .ForEach(c => c.DamagePoints += IncreaseDamagePoints);
            }

            if (enemyPlayer is Beginner)
            {
                enemyPlayer.Health += IncreaseHealthPoints;

                //foreach (ICard cardInfo in enemyPlayer.CardRepository.Cards)
                //{
                //    cardInfo.DamagePoints += IncreaseDamagePoints;
                //}

                enemyPlayer.CardRepository
                            .Cards
                            .ToList()
                            .ForEach(c => c.DamagePoints += IncreaseDamagePoints);
            }

            //•	Before the fight, both players get bonus health points from their deck.
            attackPlayer.Health += attackPlayer.CardRepository.Cards.Sum(c => c.HealthPoints);
            enemyPlayer.Health += enemyPlayer.CardRepository.Cards.Sum(c => c.HealthPoints); 

            while (true)
            {
                //•	Attacker attacks first and after that the enemy attacks.If one of the players is dead you should stop the fight.
                int attackerDamagePoints = attackPlayer.CardRepository.Cards.Sum(c => c.DamagePoints);

                enemyPlayer.TakeDamage(attackerDamagePoints);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                int enemyDamagePoints = enemyPlayer.CardRepository.Cards.Sum(c => c.DamagePoints);

                attackPlayer.TakeDamage(enemyDamagePoints);

                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }
    }
}
