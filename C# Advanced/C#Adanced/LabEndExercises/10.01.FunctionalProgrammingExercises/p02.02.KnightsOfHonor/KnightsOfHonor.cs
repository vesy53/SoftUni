namespace p02._02.KnightsOfHonor
{
    using System;

    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Action<string> printActDelName = ConsolePrint;

            foreach (string name in names)
            {
                printActDelName(name);
            }
        }

        private static void ConsolePrint(string name)
        {
            Console.WriteLine($"Sir {name}");
        }
    }
}