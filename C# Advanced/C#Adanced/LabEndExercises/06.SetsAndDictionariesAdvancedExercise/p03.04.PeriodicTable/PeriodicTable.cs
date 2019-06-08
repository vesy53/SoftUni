namespace p03._04.PeriodicTable
{
    using System;
    using System.Collections.Generic;

    class PeriodicTable
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicalElements = new SortedSet<string>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] chemicalCompounds = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                chemicalElements.UnionWith(chemicalCompounds);
            }

            Console.WriteLine(string.Join(" ", chemicalElements));
        }
    }
}