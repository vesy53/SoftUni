namespace p07._01.InfernoInfinity.Models.Gems.Contracts
{
    using p07._01.InfernoInfinity.Enums;

    public interface IGem
    {
        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }

        LevelClarity LevelClarity { get; }
    }
}
