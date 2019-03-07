namespace p03._01.BoomingCannon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BoomingCannon
    {
        static void Main(string[] args)
        { 
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int skip = numbers[0];
            int shotSize = numbers[1];

            string input = Console.ReadLine();

            List<string> result = new List<string>();

            int index = input.IndexOf("\\<<<");

            while (index != -1)
            {
                int destroyedTargetBounds = index + 4 + skip + shotSize;
                int nextIndex = input.IndexOf("\\<<<", index + 1);

                if (nextIndex != -1 && nextIndex < destroyedTargetBounds)
                {
                    destroyedTargetBounds = nextIndex;
                }

                int startIndex = index + 4 + skip;
                int length = destroyedTargetBounds - index - 4 - skip;

                if (length > 0)
                {
                    if (startIndex + length >= input.Length)
                    {
                        length = input.Length - startIndex;
                    }

                    string destroyedTarget = input.Substring(startIndex, length);
                    result.Add(destroyedTarget);
                }

                index = input.IndexOf("\\<<<", index + 1);
            }

            Console.WriteLine(string.Join(@"/\", result));
        }
    }
}
