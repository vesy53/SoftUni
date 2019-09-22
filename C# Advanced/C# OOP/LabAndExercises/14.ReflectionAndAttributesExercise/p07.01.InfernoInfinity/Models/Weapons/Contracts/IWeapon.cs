namespace p07._01.InfernoInfinity.Models.Weapons.Contracts
{
    using System.Collections.Generic;

    using p07._01.InfernoInfinity.Enums;
    using p07._01.InfernoInfinity.Models.Gems.Contracts;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        int NumSockets { get; }

        LevelRarity LevelRarity { get; }

        IReadOnlyCollection<IGem> Sockets { get; }

        void AddGem(IGem gem, int index);

        void RemoveGem(int index);
    }
}
