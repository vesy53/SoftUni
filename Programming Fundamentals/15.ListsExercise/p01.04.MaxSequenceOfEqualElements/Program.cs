namespace p01MaxSequenceOfEqualElements3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var maxSequenceOfEqualElements = FindMaxSequenceOfEqualElements(numbers);

            Console.WriteLine(string.Join(" ", maxSequenceOfEqualElements));
        }

        static int[] FindMaxSequenceOfEqualElements(int[] arr)
        {
            List<int> longestSequence = new List<int>();
            List<int> currentSequence = new List<int>();

            currentSequence.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int searchNum = currentSequence[0];

                if (currentNum == searchNum)
                {
                    currentSequence.Add(currentNum);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }

                    currentSequence.Clear();
                    currentSequence.Add(currentNum);
                }         
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }

            return longestSequence.ToArray();
        }
    }
}
