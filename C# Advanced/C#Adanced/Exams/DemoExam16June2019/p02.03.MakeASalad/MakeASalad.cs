namespace p02._03.MakeASalad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MakeASalad
    {
        static void Main(string[] args)
        {
            string[] vegetables = Console.ReadLine()
                .Split(" ", 
                    StringSplitOptions
                    .RemoveEmptyEntries);
            int[] calories = Console.ReadLine()
                .Split(" ", 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var data = new Dictionary<string, int>
            {
                { "tomato", 80 },
                { "carrot", 136 },
                { "lettuce", 109 },
                { "potato", 215 }
            };

            Stack<int> saladsToMake = new Stack<int>();

            foreach (int salad in calories)
            {
                saladsToMake.Push(salad);
            }

            Queue<string> vegetablesToTake = new Queue<string>();

            foreach (string vegetable in vegetables)
            {
                vegetablesToTake.Enqueue(vegetable);
            }

            List<int> finishedSalads = new List<int>();

            while (saladsToMake.Count > 0 && 
                   vegetablesToTake.Count > 0)
            {
                int neededSalad = saladsToMake.Peek();

                while (neededSalad > 0 && 
                       vegetablesToTake.Count > 0)
                {
                    string vegetable = vegetablesToTake.Dequeue();

                    if (data.ContainsKey(vegetable))
                    {
                        neededSalad -= data[vegetable];
                    }
                }

                if (neededSalad < saladsToMake.Peek())
                {
                    finishedSalads.Add(saladsToMake.Pop());
                }
            }

            if (finishedSalads.Count > 0)
            {
                Console.WriteLine(string.Join(" ", finishedSalads));
            }

            if (vegetablesToTake.Count > 0)
            {
                Console.WriteLine(string.Join(" ", vegetablesToTake));
            }
            else if (saladsToMake.Count > 0)
            {
                Console.WriteLine(string.Join(" ", saladsToMake));
            }
        }
    }
}