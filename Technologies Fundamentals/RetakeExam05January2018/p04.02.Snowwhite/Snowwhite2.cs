namespace p04._02.Snowwhite
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Snowwhite2
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            Dictionary<string, int> colors = new Dictionary<string, int>();

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

                string currentDwarfId = $"{name} <:> {hatColor}";

                if (dwarfs.ContainsKey(currentDwarfId) == false)
                {
                    dwarfs.Add(currentDwarfId, physics);

                    if (colors.ContainsKey(hatColor) == false)
                    {
                        colors.Add(hatColor, 1);
                    }
                    else
                    {
                        colors[hatColor]++;
                    }
                }
                else
                {
                    int oldValue = dwarfs[currentDwarfId];

                    if (physics > oldValue)
                    {
                        dwarfs[currentDwarfId] = physics;
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> sortedDwarfs = dwarfs
                .OrderByDescending(d => d.Value)
                .ThenByDescending(d => colors[d.Key
                    .Split(new[] { " <:> " }, 
                        StringSplitOptions
                        .RemoveEmptyEntries)[1]])
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var dwarf in sortedDwarfs)
            {
                string dwarfId = dwarf.Key;
                string[] dwarfIdTokens = dwarfId
                    .Split(new[] { " <:> " }, 
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string dwarfName = dwarfIdTokens[0];
                string dwarfHatColor = dwarfIdTokens[1];

                int dwarfPhsyics = dwarf.Value;

                Console.WriteLine(
                    $"({dwarfHatColor}) {dwarfName} <-> {dwarfPhsyics}");
            }
        }
    }
}
