namespace p08._03.MilitaryElite.Contracts
{
    using p08._03.MilitaryElite.Enums;

    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
