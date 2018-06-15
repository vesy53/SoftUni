using System;

namespace p06Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFirst = int.Parse(Console.ReadLine());
            int numSec = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= numFirst; i++)
            {
                for (int j = 1; j <= numSec; j++)
                {
                    Console.Write($"({i} <-> {j}) ");

                    counter++;

                    if (counter == maxBattles)
                    {
                        break;
                    }

                }

                if (counter == maxBattles)
                {
                    break;
                }
            }
        }
    }
}
