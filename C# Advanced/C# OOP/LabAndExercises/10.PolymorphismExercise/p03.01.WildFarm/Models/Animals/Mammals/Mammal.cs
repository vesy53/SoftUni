namespace p03._01.WildFarm.Models.Animals.Mammals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;

    public abstract class Mammal : Animal, IMammal
    {
        protected Mammal(
            string name, 
            double weight, 
            string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }
    }
}
