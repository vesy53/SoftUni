namespace p06._01.HotPotato
{
    using System;
    using System.Collections.Generic;

    class HotPotato
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);
            int jump = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(names);

            while (queue.Count != 1)
            {
                for (int i = 1; i < jump; i++)
                {
                    string jumpedName = queue.Dequeue();

                    queue.Enqueue(jumpedName);
                }

                string removedName = queue.Dequeue();

                Console.WriteLine($"Removed {removedName}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
