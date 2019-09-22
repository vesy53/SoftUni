namespace MXGP.Core.Factories.Contracts
{
    using MXGP.Models.Riders.Contracts;
    //using Models.Riders.Contracts;

    public interface IRiderFactory
    {
        IRider CreateRider(string riderName);
    }
}
