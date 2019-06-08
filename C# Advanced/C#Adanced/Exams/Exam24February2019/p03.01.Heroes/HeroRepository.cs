namespace p03._01.Heroes
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count => this.data.Count();

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            Hero hero = this.data
                .Where(d => d.Name == name)
                .FirstOrDefault();

            if (hero != null)
            {
                this.data.Remove(hero);
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            //return this.data
            //.OrderByDescending(x => x.Item.Strength)
            //.FirstOrDefault();

            int hightStrength = 0;
            Hero hero = new Hero();

            foreach (Hero elements in this.data)
            {
                int strength = elements.Item.Strength;

                if (strength > hightStrength)
                {
                    hightStrength = strength;
                    hero = elements;
                }
            }

            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            //return this.data
            //.OrderByDescending(x => x.Item.Ability)
            //.FirstOrDefault();

            int hightAbility = 0;
            Hero hero = new Hero();

            foreach (Hero elements in this.data)
            {
                int ability = elements.Item.Ability;

                if (ability > hightAbility)
                {
                    hightAbility = ability;
                    hero = elements;
                }
            }

            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            //return this.data
            //.OrderByDescending(x => x.Item.Intelligence)
            //.FirstOrDefault();

            int hightIntelligence = 0;
            Hero hero = new Hero();

            foreach (Hero elements in this.data)
            {
                int intelligence = elements.Item.Intelligence;

                if (intelligence > hightIntelligence)
                {
                    hightIntelligence = intelligence;
                    hero = elements;
                }
            }

            return hero;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (Hero element in this.data)
            {
                builder
                    .AppendLine(element.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
