namespace p04._03.Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Snowwhite3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Dwarf> dwarfs = new List<Dwarf>();

            while (input != "Once upon a time")
            {
                string[] tokens = input
                    .Split(new string[] { " <:> " }, 
                        StringSplitOptions
                        .None);
                string name = tokens[0];
                string color = tokens[1];
                int physics = int.Parse(tokens[2]);

                Dwarf repeat = dwarfs
                    .Find(x => x.Name == name && x.Color == color);

                if (repeat == null)
                {
                    Dwarf dwarf = new Dwarf(name, color, physics);
                    dwarfs.Add(dwarf);
                }
                else
                {
                    repeat.Physics = Math.Max(repeat.Physics, physics);
                }

                input = Console.ReadLine();
            }

            foreach (var dwarf in dwarfs
                .OrderByDescending(x => x.Physics)
                .ThenByDescending(x => dwarfs.Count(y => y.Color == x.Color)))
            {
                string hatColor = dwarf.Color;
                string name = dwarf.Name;
                int physics = dwarf.Physics;

                Console.WriteLine($"({hatColor}) {name} <-> {physics}");
            }
        }
    }

    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }

        public Dwarf(string name, string color, int physics)
        {
            this.Name = name;
            this.Color = color;
            this.Physics = physics;
        }
    }
}
