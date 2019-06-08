namespace p02._01.KnightsOfHonor
{
    using System;

    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Action<string> action = a => Console.WriteLine($"Sir {a}");

            // second method
            //Action<string> action = delegate (string name)
            //{
            //    Console.WriteLine($"Sir {name}");
            //};

            foreach (string name in names)
            {
                action(name);
            }
        }
    }
}
