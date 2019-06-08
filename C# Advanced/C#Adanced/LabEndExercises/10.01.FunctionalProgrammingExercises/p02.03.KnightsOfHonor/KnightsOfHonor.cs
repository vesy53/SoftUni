namespace p02._03.KnightsOfHonor
{
    using System;

    class KnightsOfHonor
    {
        public delegate void PrintName(string name);

        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(new char[] { ' ', '\t' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            foreach (var name in names)
            {
                PrintName printName = ConsolePrint;

                printName(name);
            }
        }

        static void ConsolePrint(string name)
        {
            Console.WriteLine($"Sir {name}");
        }
    }
}