namespace p07._01.InfernoInfinity.Models.Weapons
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Contracts;
    using p07._01.InfernoInfinity.Enums;
    using p07._01.InfernoInfinity.Models.Gems.Contracts;

    public abstract class Weapon : IWeapon
    {
        private int minDamage;
        private int maxDamage;
        private IGem[] sockets;

        protected Weapon(
            string name, 
            int minDamage, 
            int maxDamage, 
            int numSockets, 
            LevelRarity levelRarity)
        {
            this.Name = name;
            this.LevelRarity = levelRarity;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.NumSockets = numSockets;

            this.sockets = new IGem[numSockets];
        }

        public string Name { get; private set; }

        public int MinDamage
        {
            get
            {
                return this.minDamage;
            }

            private set
            {
                this.minDamage = value * (int)this.LevelRarity;
            }
        }

        public int MaxDamage
        {
            get
            {
                return this.maxDamage;
            }

            private set
            {
                this.maxDamage = value * (int)this.LevelRarity;
            }
        }

        public int NumSockets { get; private set; }

        public LevelRarity LevelRarity { get; private set; }

        public IReadOnlyCollection<IGem> Sockets => this.sockets;

        public void AddGem(IGem gem, int index)
        {
            if (index < 0 ||
                index >= this.sockets.Length)
            {
                return;
            }

            this.sockets[index] = gem;

            IncreaseDemageValuesByGem(gem);
        }

        public void RemoveGem(int index)
        {
            if (index < 0 ||
                index >= this.sockets.Length)
            {
                return;
            }

            IGem gemToRemove = this.sockets[index];
            this.sockets[index] = null;

            DecreaseDemageValuesByGem(gemToRemove);
        }

        private void IncreaseDemageValuesByGem(IGem gem)
        {
            this.minDamage += gem.Strength * 2 + gem.Agility;
            this.maxDamage += gem.Strength * 3 + gem.Agility * 4;
        }

        private void DecreaseDemageValuesByGem(IGem gemToRemove)
        {
            this.minDamage -= gemToRemove.Strength * 2;
            this.maxDamage -= gemToRemove.Strength * 3;

            this.minDamage -= gemToRemove.Agility;
            this.maxDamage -= gemToRemove.Agility * 4;
        }

        public override string ToString()
        {
            int strenght = this.Sockets
                .Where(x => x != null)
                .Sum(x => x.Strength);
            int agility = this.Sockets
                .Where(x => x != null)
                .Sum(x => x.Agility);
            int vitality = this.Sockets
                .Where(x => x != null)
                .Sum(x => x.Vitality);

            StringBuilder builder = new StringBuilder();

            builder
                .Append($"{this.Name}: ")
                .Append($"{this.MinDamage}-{this.MaxDamage} Damage,")
                .Append($" +{strenght} Strength,")
                .Append($" +{agility} Agility,")
                .Append($" +{vitality} Vitality");

            return builder.ToString();
        }
    }
}
