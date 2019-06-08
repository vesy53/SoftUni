namespace p03._02.PeriodicTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PeriodicTable
    {
        static void Main(string[] args)
        {
            SortedSet<string> periodicTable = new SortedSet<string>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                foreach (string element in elements)
                {
                    periodicTable.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
