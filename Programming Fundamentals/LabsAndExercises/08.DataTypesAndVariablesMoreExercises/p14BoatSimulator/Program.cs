using System;

namespace p14BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            int movesFirstBoat = 0;
            int movesSecBoat = 0;

            for (int i = 1; i <= num; i++)
            {
                string commands = Console.ReadLine();

                if (commands == "UPGRADE")
                {
                    firstBoat += (char)3;
                    secondBoat += (char)3;
                    continue;
                }

                int length = commands.Length;

                if (i % 2 == 1)
                {
                    movesFirstBoat += length;
                }
                else if (i % 2 == 0)
                {
                    movesSecBoat += length;
                }

                if (movesFirstBoat >= 50 || movesSecBoat >= 50)
                {
                    break;
                }            
            }

            if (movesFirstBoat > movesSecBoat)
            {
                Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}
