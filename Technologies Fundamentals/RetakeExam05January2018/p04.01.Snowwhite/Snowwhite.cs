namespace p04._01.Snowwhite
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Snowwhite
    {
        static void Main(string[] args)
        {
            var dataDwarf = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] dwarfToken = input
                    .Split(new string[] { " <:> " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = dwarfToken[0];
                string hatColor = dwarfToken[1];
                int physics = int.Parse(dwarfToken[2]);

                if (!dataDwarf.ContainsKey(hatColor))
                {
                    dataDwarf.Add(hatColor, new Dictionary<string, int>());
                }

                if (!dataDwarf[hatColor].ContainsKey(name))
                {
                    dataDwarf[hatColor].Add(name, physics);
                }

                if (dataDwarf[hatColor][name] < physics)
                {
                    dataDwarf[hatColor][name] = physics;
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();

            foreach (var itemDwarf in dataDwarf
                .OrderByDescending(x => x.Value.Count()))
            {
                string hatColor = itemDwarf.Key;
                Dictionary<string, int> dwarfElements = itemDwarf.Value;

                foreach (var dwarf in dwarfElements)
                {
                    string name = dwarf.Key;
                    int physics = dwarf.Value;

                    sortedDwarfs.Add($"({hatColor}) {name} <-> ", physics);
                    //sortedDwarfs.Add($"key - string", int value - physics);
                }
            }

            foreach (var dwarf in sortedDwarfs
                .OrderByDescending(x => x.Value))
            {
                string hatColorAndName = dwarf.Key;
                int physics = dwarf.Value;

                Console.WriteLine($"{hatColorAndName}{physics}");
            }
        }
    }
}
