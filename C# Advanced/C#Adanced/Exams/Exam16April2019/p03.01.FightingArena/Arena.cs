namespace p03._01.FightingArena
{
    using System.Collections.Generic;
    using System.Linq;

    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.Name = name;

            this.gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }

        public int Count => this.gladiators.Count();

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator searchGladiator = this.gladiators
                .Where(g => g.Name == name)
                .FirstOrDefault();

            if (searchGladiator != null)
            {
                this.gladiators.Remove(searchGladiator);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return this.gladiators
                .OrderByDescending(g => g.GetStatPower())
                .FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return this.gladiators
                .OrderByDescending(g => g.GetWeaponPower())
                .FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return this.gladiators
                .OrderByDescending(g => g.GetTotalPower())
                .FirstOrDefault();
        }

        public override string ToString()
        {

            string result = string.Format(
                $"{this.Name} - {this.Count} gladiators are participating.");

            return result;
        }
    }
}
