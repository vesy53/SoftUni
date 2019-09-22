namespace MXGP.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using MXGP.Models.Riders.Contracts;

    public class RiderRepository : IRepository<IRider>
    {
        private List<IRider> rider;

        public RiderRepository()
        {
            this.rider = new List<IRider>();
        }

        public void Add(IRider model)
        {
            this.rider.Add(model);
        }

        public IReadOnlyCollection<IRider> GetAll()
        {
            return this.rider.AsReadOnly();
        }

        public IRider GetByName(string name)
        {
            return this.rider
                .FirstOrDefault(m => m.Name == name);
        }

        public bool Remove(IRider model)
        {
            return this.rider.Remove(model);
        }
    }
}