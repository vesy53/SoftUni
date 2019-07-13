namespace p08._01.MilitaryElite.Contracts
{
    using System.Collections.Generic;

    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<ISoldier> Privates { get; }

        void AddPrivate(ISoldier newPrivate);
    }
}
