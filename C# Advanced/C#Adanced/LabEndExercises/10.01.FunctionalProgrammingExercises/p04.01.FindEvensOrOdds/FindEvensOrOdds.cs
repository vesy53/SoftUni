namespace p04._01.FindEvensOrOdds
{
    using System;
    using System.Linq;

    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            int[] rangeSizes = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            int satrtRange = rangeSizes[0];
            int endRange = rangeSizes[1];

            Predicate<int> predicate = delegate (int a) 
            {
                return a % 2 == 0;
            };

            for (int i = satrtRange; i <= endRange; i++)
            {
                if (command == "even" && 
                    predicate(i) == true)
                {
                    Console.Write($"{i} ");
                }
                else if (command == "odd" && 
                    predicate(i) == false)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }
    }
}
