namespace MXGP.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories.Contracts;

    public class RiderRepository : IRepository<IRider>
    {
        private readonly List<IRider> models;

        public RiderRepository()
        {
            this.models = new List<IRider>();
        }

        //public IReadOnlyCollection<IRider> Models 
        //    => this.models.AsReadOnly();

        public void Add(IRider model)
        {
            this.models.Add(model);
        }

        public IReadOnlyCollection<IRider> GetAll()
        {
            return this.models.ToList(); 
        }

        public IRider GetByName(string name)
        {
            IRider rider = this.models
                .FirstOrDefault(m => m.Name == name);

            return rider;
        }

        public bool Remove(IRider model)
        {
            return this.models.Remove(model);
        }
    }
}
