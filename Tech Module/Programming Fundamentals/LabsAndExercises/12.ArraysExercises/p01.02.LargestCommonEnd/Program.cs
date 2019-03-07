using System;

namespace p01LargestCommonEnd1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine()
                .Split(' ');
            string[] words2 = Console.ReadLine()
                .Split(' ');

            LargestCommondEnd(words1, words2);
        }

        static void LargestCommondEnd(string[] words1, string[] words2)
        {
            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < Math.Min(words1.Length, words2.Length); i++)
            {
                if (words1[i] == words2[i])
                {
                    leftCounter++;
                }
                else if (words1[words1.Length - 1 - i] == words2[words2.Length - 1 - i])
                {
                    rightCounter++;
                }
            }

            Console.WriteLine(leftCounter > rightCounter ? leftCounter : rightCounter);
        }
    }
}
