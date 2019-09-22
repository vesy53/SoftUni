using MXGP.Models.Motorcycles.Contracts;
using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public class MotorcycleRepository : IRepository<IMotorcycle>
    {
        private List<IMotorcycle> motocycles;

        public MotorcycleRepository()
        {
            this.motocycles = new List<IMotorcycle>();
        }

        public void Add(IMotorcycle model)
        {
            this.motocycles.Add(model);
        }

        public IReadOnlyCollection<IMotorcycle> GetAll()
        {
            return this.motocycles.AsReadOnly();
        }

        public IMotorcycle GetByName(string name)
        {
            return this.motocycles
                .FirstOrDefault(r => r.Model == name);
        }

        public bool Remove(IMotorcycle model)
        {
            return this.motocycles.Remove(model);
        }
    }
}
