namespace p10._01.ExplicitInterfaces.Contracts
{
    public interface IResident : INameable
    {
        string Country { get; }

        void GetName();
    }
}
