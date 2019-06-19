namespace p02._01.CryptoMaster
{
    using System;
    using System.Linq;

    class CryptoMaster
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int step = 1; step < numbers.Length; step++)
                {
                    int currentIndex = i;
                    int nextIndex = (i + step) % numbers.Length;
                    int counter = 1;

                    while (numbers[currentIndex] < numbers[nextIndex])
                    {
                        currentIndex = nextIndex;
                        nextIndex = (nextIndex + step) % numbers.Length;
                        counter++;
                    }

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
            }

            Console.WriteLine(maxCounter);
        }
    }
}