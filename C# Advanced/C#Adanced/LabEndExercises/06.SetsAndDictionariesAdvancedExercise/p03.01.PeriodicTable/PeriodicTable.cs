namespace p03._01.PeriodicTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PeriodicTable
    {
        static void Main(string[] args)
        {
            HashSet<string> periodicTable = new HashSet<string>();

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

            var orderElement = periodicTable
                .OrderBy(e => e);

            Console.WriteLine(string.Join(" ", orderElement));

            //foreach (string element in periodicTable
            //    .OrderBy(e => e))
            //{
            //    Console.Write($"{element} ");
            //}
            //
            //Console.WriteLine();
        }
    }
}
