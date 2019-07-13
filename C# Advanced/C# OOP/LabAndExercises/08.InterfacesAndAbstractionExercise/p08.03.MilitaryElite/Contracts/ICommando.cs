﻿namespace p08._03.MilitaryElite.Contracts
{
    using System.Collections.Generic;

    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
