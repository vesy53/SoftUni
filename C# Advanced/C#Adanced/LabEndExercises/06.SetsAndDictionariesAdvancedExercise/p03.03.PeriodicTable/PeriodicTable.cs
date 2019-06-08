namespace p03._03.PeriodicTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PeriodicTable
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicalElements = new SortedSet<string>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                List<string> elements = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .ToList();

                elements
                    .ForEach(x => chemicalElements.Add(x));
            }

            Console.WriteLine(string.Join(" ", chemicalElements));
        }
    }
}