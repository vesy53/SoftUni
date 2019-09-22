namespace p07._01.InfernoInfinity.Data.Contracts
{
    using p07._01.InfernoInfinity.Models.Weapons.Contracts;

    public interface IRepository
    {
        void AddWeapon(IWeapon weapon);

        IWeapon GetWeapon(string name);

        string PrintWeapon(IWeapon weapon);
    }
}
