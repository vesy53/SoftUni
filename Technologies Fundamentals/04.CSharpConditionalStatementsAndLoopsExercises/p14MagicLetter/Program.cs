using System;

namespace p14MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secLetter; i++)
            {
                for (char j = firstLetter; j <= secLetter; j++)
                {
                    for (char m = firstLetter; m <= secLetter; m++)
                    {
                        if (i != thirdLetter && j != thirdLetter && m != thirdLetter)
                        {
                            Console.Write($"{i}{j}{m} ");
                        }
                    }
                }
            }
        }
    }
}
