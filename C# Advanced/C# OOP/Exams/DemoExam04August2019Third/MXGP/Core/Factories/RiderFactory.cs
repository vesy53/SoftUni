namespace MXGP.Core.Factories
{
    using Contracts;
    using MXGP.Models.Riders;
    using MXGP.Models.Riders.Contracts;

    public class RiderFactory : IRiderFactory
    {
        public IRider CreateRider(string name)
        {
            IRider rider = new Rider(name);

            return rider;
        }
    }
}
