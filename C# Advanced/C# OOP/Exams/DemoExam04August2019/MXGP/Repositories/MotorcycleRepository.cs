namespace MXGP.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Repositories.Contracts;

    public class MotorcycleRepository : IRepository<IMotorcycle>
    {
        private readonly List<IMotorcycle> models;

        public MotorcycleRepository()
        {
            this.models = new List<IMotorcycle>();
        }

        //public IReadOnlyCollection<IMotorcycle> Models
        //    => this.models.AsReadOnly();

        public void Add(IMotorcycle model)
        {
            this.models.Add(model);
        }

        public IReadOnlyCollection<IMotorcycle> GetAll()
        {
            return this.models.ToList(); 
        }

        public IMotorcycle GetByName(string name)
        {
            IMotorcycle motorcycle = this.models
                .FirstOrDefault(m => m.Model == name);

            return motorcycle;
        }

        public bool Remove(IMotorcycle model)
        {
            // Removes an entity from the collection.
            return this.models.Remove(model);
        }
    }
}
