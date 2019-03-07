namespace p01._02.Hogswatch
{
    using System;

    class Hogswatch2
    {
        static void Main(string[] args)
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int initialGifts = int.Parse(Console.ReadLine());

            int presents = initialGifts;
            int countBack = 0;
            int totalGift = 0;

            for (int i = 1; i <= homesToVisit; i++)
            {
                int numChildren = int.Parse(Console.ReadLine());

                if (presents >= numChildren)
                {
                    presents -= numChildren;
                    continue;
                }

                int restGifts = numChildren - presents;
                int restHomes = homesToVisit - i;
                countBack++;

                int result = initialGifts / i * restHomes + restGifts;
                totalGift += result;
                presents += result - numChildren;
            }

            if (countBack == 0)
            {
                Console.WriteLine(presents);
            }
            else
            {
                Console.WriteLine(countBack);
                Console.WriteLine(totalGift);
            }
        }
    }
}
