namespace p02._05.MakeASalad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MakeASalad
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, int>
            {
                { "tomato", 80 },
                { "carrot", 136 },
                { "lettuce", 109 },
                { "potato", 215 }
            };

            //var data = new Dictionary<string, int>();
            //data.Add("tomato", 80);
            //data.Add("carrot", 136);
            //data.Add("lettuce", 109);
            //data.Add("potato", 215);

            string[] inputVegetables = Console.ReadLine()
               .Split(' ',
                   StringSplitOptions
                   .RemoveEmptyEntries);
            int[] inputCalories = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<string> queueVegetables = new Queue<string>(inputVegetables);
            Stack<int> stackCalories = new Stack<int>(inputCalories);

            Queue<int> salads = new Queue<int>();

            while (queueVegetables.Count != 0 &&
                   stackCalories.Count != 0)
            {
                int calorie = stackCalories.Peek();

                while (calorie > 0 &&
                       queueVegetables.Count > 0)
                {
                    string vegetable = queueVegetables.Dequeue();

                    if (data.ContainsKey(vegetable))
                    {
                        calorie -= data[vegetable];
                    }
                }

                salads.Enqueue(stackCalories.Pop());
            }

            if (salads.Count > 0)
            {
                Console.WriteLine(string.Join(" ", salads));
            }

            if (queueVegetables.Count > 0)
            {
                Console.WriteLine(
                    string.Join(" ", queueVegetables));
            }
            else if (stackCalories.Count != 0)
            {
                Console.WriteLine(
                    string.Join(" ", stackCalories));
            }
        }
    }
}
