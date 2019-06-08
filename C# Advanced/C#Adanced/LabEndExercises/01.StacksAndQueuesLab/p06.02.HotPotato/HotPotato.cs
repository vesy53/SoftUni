namespace p06._02.HotPotato
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
                for (int i = 1; i <= jump; i++)
                {
                    if (i == jump)
                    {
                        Console.WriteLine($"Removed {queue.Dequeue()}");
                    }
                    else
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
