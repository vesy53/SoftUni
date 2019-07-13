namespace p08._01.MilitaryElite.Contracts
{
    using p08._01.MilitaryElite.Enums;

    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
