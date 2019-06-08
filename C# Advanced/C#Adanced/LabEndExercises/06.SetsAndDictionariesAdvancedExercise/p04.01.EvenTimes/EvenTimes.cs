namespace p04._01.EvenTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class EvenTimes
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<int, int>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!data.ContainsKey(number))
                {
                    data.Add(number, 0);
                }

                data[number]++;
            }

            foreach (var itemData in data
                .Where(i => i.Value % 2 == 0))
            {
                int number = itemData.Key;

                Console.WriteLine($"{number}");
            }

            //foreach (var itemData in data)
            //{
            //    int number = itemData.Key;
            //    int count = itemData.Value;
            //
            //    if (count % 2 == 0)
            //    {
            //        Console.WriteLine($"{number}");
            //    }
            //}
        }
    }
}
