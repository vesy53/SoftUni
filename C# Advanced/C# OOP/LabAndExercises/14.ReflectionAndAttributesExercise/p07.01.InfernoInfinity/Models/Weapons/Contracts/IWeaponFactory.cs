namespace p07._01.InfernoInfinity.Models.Weapons.Contracts
{
    using p07._01.InfernoInfinity.Enums;

    public interface IWeaponFactory
    {
        IWeapon CreateWeapon(string type, string name, LevelRarity rarityLevel);
    }
}
