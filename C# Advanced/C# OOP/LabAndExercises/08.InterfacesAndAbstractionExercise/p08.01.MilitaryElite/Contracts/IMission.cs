namespace p08._01.MilitaryElite.Contracts
{
    using p08._01.MilitaryElite.Enums;

    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
