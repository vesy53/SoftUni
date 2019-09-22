namespace p07._01.InfernoInfinity.Models.Gems.Contracts
{
    using p07._01.InfernoInfinity.Enums;

    public interface IGemFactory
    {
        IGem CreateGem(string type, LevelClarity clarity);
    }
}
