namespace p10._01.ExplicitInterfaces.Contracts
{
    public interface IPerson : INameable
    {
        int Age { get; }

        void GetName();
    }
}
