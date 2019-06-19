namespace p02._04.MakeASalad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MakeASalad
    {
        static void Main(string[] args)
        {
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

            Queue<int> queueVegetablesInt = new Queue<int>();

            for (int i = 0; i < inputVegetables.Length; i++)
            {
                string vegetable = inputVegetables[i];

                int caloriesVegetable = TakeValueOfTheVegetable(vegetable);

                queueVegetablesInt.Enqueue(caloriesVegetable);
            }

            Queue<string> queueVegetablesStr = new Queue<string>(inputVegetables);
            Stack<int> stackCalories = new Stack<int>(inputCalories);

            Queue<int> salad = new Queue<int>();

            while (queueVegetablesInt.Count != 0 &&
                    stackCalories.Count != 0)
            {
                int vegetableCal = queueVegetablesInt.Dequeue();
                int calories = stackCalories.Pop();
                int saladCalories = calories;
                queueVegetablesStr.Dequeue();

                if (vegetableCal < calories)
                {
                    while (calories > 0)
                    {
                        calories -= vegetableCal;

                        if (calories > 0 &&
                            queueVegetablesInt.Count != 0)
                        {
                            vegetableCal = queueVegetablesInt.Dequeue();
                            queueVegetablesStr.Dequeue();
                        }
                    }
                }

                salad.Enqueue(saladCalories);
            }

            if (salad.Count > 0)
            {
                Console.WriteLine(string.Join(" ", salad));
            }

            if (queueVegetablesInt.Count > 0)
            {
                Console.WriteLine(
                    string.Join(" ", queueVegetablesStr));
            }
            else
            {
                Console.WriteLine(
                    string.Join(" ", stackCalories));
            }
        }

        private static int TakeValueOfTheVegetable(
            string vegetable)
        {
            int caloriesVegetable = 0;

            if (vegetable == "tomato")
            {
                caloriesVegetable = 80;
            }
            else if (vegetable == "carrot")
            {
                caloriesVegetable = 136;
            }
            else if (vegetable == "lettuce")
            {
                caloriesVegetable = 109;
            }
            else if (vegetable == "potato")
            {
                caloriesVegetable = 215;
            }

            return caloriesVegetable;
        }
    }
}
