namespace PlayersAndMonsters.Core
{
    using System;

    using PlayersAndMonsters.Heroes.Elfs;
    using PlayersAndMonsters.Heroes.Knights;
    using PlayersAndMonsters.Heroes.Wizards;

    public class Engine
    {
        public void Run()
        {
            MuseElf elf = new MuseElf("Mimi", 2);
            SoulMaster soulMaster = new SoulMaster("Pesho", 5);
            BladeKnight bladeKnight = new BladeKnight("Gosho", 2);

            Console.WriteLine($"Elf name: {elf.Username}, Level: {elf.Level}");
            Console.WriteLine(
                $"SoulMaster name: {soulMaster.Username}, Level: {soulMaster.Level}");
            Console.WriteLine(
                $"BladeKnight name: {bladeKnight.Username}, Level: {bladeKnight.Level}");
        }
    }
}
