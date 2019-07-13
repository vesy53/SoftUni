namespace p08._03.MilitaryElite.Contracts
{
    using p08._03.MilitaryElite.Enums;

    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
