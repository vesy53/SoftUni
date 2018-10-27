using System;

namespace p06TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        char letterI = (char)('a' + i);
                        char letterJ = (char)('a' + j);
                        char letterK = (char)('a' + k);

                        Console.WriteLine($"{letterI}{letterJ}{letterK}");
                    }
                }
            }
        }
    }
}
