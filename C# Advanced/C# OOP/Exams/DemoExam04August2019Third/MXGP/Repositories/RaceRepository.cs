namespace MXGP.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using MXGP.Models.Races.Contracts;

    public class RaceRepository : IRepository<IRace>
    {
        private List<IRace> race;

        public RaceRepository()
        {
            this.race = new List<IRace>();
        }

        public void Add(IRace model)
        {
            this.race.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return this.race.AsReadOnly();
        }

        public IRace GetByName(string name)
        {
            return this.race
                .FirstOrDefault(m => m.Name == name);
        }

        public bool Remove(IRace model)
        {
            return this.race.Remove(model);
        }
    }
}