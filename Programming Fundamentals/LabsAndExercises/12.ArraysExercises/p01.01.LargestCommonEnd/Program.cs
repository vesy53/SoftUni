using System;

namespace p01LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine()
                .Split(' ');
            string[] words2 = Console.ReadLine()
                .Split(' ');

            int leftCounter = LargestCommondLeft(words1, words2);
            int rightCounter = LargestCommondRight(words1, words2);

            Console.WriteLine(leftCounter > rightCounter ? leftCounter : rightCounter);
        }

        static int LargestCommondLeft(string[] words1, string[] words2)
        {
            int leftCounter = 0;
           
            for (int i = 0; i < Math.Min(words1.Length, words2.Length); i++)
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

        static int LargestCommondRight(string[] words1, string[] words2)
        {
            int rightCounter = 0;

            for (int i = 0; i < Math.Min(words1.Length, words2.Length); i++)
            {
                if (words1[words1.Length - 1 - i] == words2[words2.Length - 1 - i])
                {
                    rightCounter++;
                }
                else
                {
                    break;
                }
            }

            return rightCounter;
        }
    }
}
