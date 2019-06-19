namespace p02._01.MakeASalad
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

            Queue<int> queueVegetables = new Queue<int>();

            for (int i = 0; i < inputVegetables.Length; i++)
            {
                string vegetable = inputVegetables[i];

                int caloriesVegetable = TakeValueOfTheVegetable(vegetable); 

                queueVegetables.Enqueue(caloriesVegetable);
            }

            Stack<int> stackCalories = new Stack<int>(inputCalories);

            Queue<int> salad = new Queue<int>();

            while (queueVegetables.Count != 0 &&
                    stackCalories.Count != 0)
            {
                int vegetableCal = queueVegetables.Dequeue();
                int calories = stackCalories.Pop();
                int saladCalories = calories;

                if (vegetableCal < calories)
                {
                    while (calories > 0)
                    {
                        calories -= vegetableCal;

                        if (calories > 0 && 
                            queueVegetables.Count != 0)
                        {
                            vegetableCal = queueVegetables.Dequeue();
                        }
                    }

                    salad.Enqueue(saladCalories);
                }
                else
                {
                    salad.Enqueue(saladCalories);
                }
            }

            if (salad.Count > 0)
            {
                Console.WriteLine(string.Join(" ", salad));
            }

            if (queueVegetables.Count > 0)
            {
                Queue<string> queue = 
                    TakeVegetablesNameOfThevalue(queueVegetables);

                Console.WriteLine(string.Join(" ", queue));
            }
            else
            {
                Console.WriteLine(
                    string.Join(" ", stackCalories));
            }
        }

        private static Queue<string> TakeVegetablesNameOfThevalue(
            Queue<int> queueVegetables)
        {
            Queue<string> queue = new Queue<string>();

            foreach (int item in queueVegetables)
            {
                string vegetable = string.Empty;

                if (item == 80)
                {
                    vegetable = "tomato";
                }
                else if (item == 136)
                {
                    vegetable = "carrot";
                }
                else if (item == 109)
                {
                    vegetable = "lettuce";
                }
                else if (item == 215)
                {
                    vegetable = "potato";
                }

                queue.Enqueue(vegetable);
            }

            return queue;
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
