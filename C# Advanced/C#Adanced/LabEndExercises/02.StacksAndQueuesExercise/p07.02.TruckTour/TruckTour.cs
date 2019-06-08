namespace p07._02.TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TruckTour
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < number; i++)
            {
                int[] petrolPumpArgs = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                queue.Enqueue(petrolPumpArgs);
            }

            for (int i = 0; i < number; i++)
            {
                int fuel = 0;

                for (int j = 0; j < queue.Count; j++)
                {
                    int[] petrolPumpArgs = queue.Dequeue();

                    int amountOfPetrol = petrolPumpArgs[0];
                    int distance = petrolPumpArgs[1];

                    queue.Enqueue(petrolPumpArgs);

                    fuel += amountOfPetrol - distance;

                    if (fuel < 0)
                    {
                        i += j;
                        break;
                    }
                }

                if (fuel >= 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}