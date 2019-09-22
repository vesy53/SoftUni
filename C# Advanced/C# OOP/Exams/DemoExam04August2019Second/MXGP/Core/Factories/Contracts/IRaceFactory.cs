namespace MXGP.Core.Factories.Contracts
{
    using MXGP.Models.Races.Contracts;
    //using Models.Races.Contracts;

    public interface IRaceFactory
    {
        IRace CreateRace(string name, int laps);
    }
}
