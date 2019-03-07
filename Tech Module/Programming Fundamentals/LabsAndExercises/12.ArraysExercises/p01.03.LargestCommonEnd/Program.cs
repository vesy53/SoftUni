using System;

namespace p01LargestCommonEnd2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine()
                .Split(' ');
            string[] words2 = Console.ReadLine()
                .Split(' ');

            int leftCounter = LargestCommonEnd(words1, words2);

            Array.Reverse(words1);
            Array.Reverse(words2);

            int rightCount = LargestCommonEnd(words1, words2);

            Console.WriteLine(leftCounter > rightCount ? leftCounter : rightCount);
        }

        static int LargestCommonEnd(string[] words1, string[] words2)
        {
            int minLength = Math.Min(words1.Length, words2.Length);
            int leftCounter = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (words1[i] == words2[i])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
            }

            return leftCounter;
        }
    }
}
