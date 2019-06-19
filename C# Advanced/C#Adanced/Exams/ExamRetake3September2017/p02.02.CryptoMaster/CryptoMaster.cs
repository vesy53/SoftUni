namespace p02._02.CryptoMaster
{
    using System;
    using System.Linq;

    class CryptoMaster
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ".ToCharArray(),
                    StringSplitOptions
                    .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int maxSeqLength = 0;

            for (int step = 1; step < numbers.Length; step++)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    int currentIndex = i;
                    int nextIndex = (i + step) % numbers.Length;
                    int seqLength = 1;

                    while (numbers[currentIndex] < numbers[nextIndex])
                    {
                        currentIndex = nextIndex;
                        nextIndex = (nextIndex + step) % numbers.Length;
                        seqLength++;
                    }

                    if (seqLength > maxSeqLength)
                    {
                        maxSeqLength = seqLength;
                    }
                }
            }

            Console.WriteLine(maxSeqLength);
        }
    }
}