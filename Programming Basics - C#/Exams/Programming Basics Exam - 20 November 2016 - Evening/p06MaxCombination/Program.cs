using System;

namespace p06MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombination = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    Console.Write($"<{i}-{j}>");

                    if (counter == maxCombination)
                    {
                        break;
                    }

                }

                if (counter == maxCombination)
                {
                    break;
                }
            }
        }
    }
}
