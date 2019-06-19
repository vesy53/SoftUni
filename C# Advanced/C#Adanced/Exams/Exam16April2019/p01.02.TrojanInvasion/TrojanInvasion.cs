namespace p01._02.TrojanInvasion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TrojanInvasion
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] platesSpartan = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queuePlates = new Queue<int>(platesSpartan);

            Stack<int> stackWarriors = new Stack<int>();

            for (int i = 1; i < number + 1; i++)
            {
                int[] trojanWarriors = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                stackWarriors = new Stack<int>(trojanWarriors);

                if (i % 3 == 0)
                {
                    int newPlate = int.Parse(Console.ReadLine());

                    Queue<int> queue = new Queue<int>();

                    FullTheNewQueue(queuePlates, queue);

                    queue.Enqueue(newPlate);

                    queuePlates = new Queue<int>(queue);
                }

                while (queuePlates.Any() && 
                       stackWarriors.Any())
                {
                    int plate = queuePlates.Dequeue();
                    int warrior = stackWarriors.Pop();

                    if (warrior > plate)
                    {
                        stackWarriors.Push(warrior - plate);
                    }
                    else if (warrior < plate)
                    {
                        Queue<int> queue = new Queue<int>();

                        queue.Enqueue(plate - warrior);

                        FullTheNewQueue(queuePlates, queue);

                        queuePlates = new Queue<int>(queue);
                    }
                }

                if (queuePlates.Count == 0)
                {
                    break;
                }
            }

            if (stackWarriors.Count != 0)
            {
                Console.WriteLine(
                    $"The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine(
                    $"Warriors left: {string.Join(", ", stackWarriors)}");
            }
            else
            {
                Console.WriteLine(
                    $"The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine(
                    $"Plates left: {string.Join(", ", queuePlates)}");
            }
        }

        private static void FullTheNewQueue(
            Queue<int> queuePlates, 
            Queue<int> queue)
        {
            while (queuePlates.Any())
            {
                queue.Enqueue(queuePlates.Dequeue());
            }
        }
    }
}
