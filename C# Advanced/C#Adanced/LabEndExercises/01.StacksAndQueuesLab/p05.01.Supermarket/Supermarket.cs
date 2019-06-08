namespace p05._01.Supermarket
{
    using System;
    using System.Collections.Generic;

    class Supermarket
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            while (name.Equals("End") == false)
            {
                if (name.Equals("Paid"))
                {
                    while (queue.Count != 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(name);
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
