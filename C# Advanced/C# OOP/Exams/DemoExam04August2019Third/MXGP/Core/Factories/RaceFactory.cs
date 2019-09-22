namespace MXGP.Core.Factories
{
    using Contracts;
    using MXGP.Models.Races;
    using MXGP.Models.Races.Contracts;

    public class RaceFactory : IRaceFactory
    {
        public IRace CreateRace(string name, int laps)
        {
            IRace race = new Race(name, laps);

            return race;
        }
    }
}
