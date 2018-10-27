namespace p04._02.CharacterMultiplier
{
    using System;

    class CharacterMultiplier2
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            char[] firstArr = input[0].ToCharArray();
            char[] secondArr = input[1].ToCharArray();

            int minLength = Math.Min(firstArr.Length, secondArr.Length);
            int result = 0;

            for (int i = 0; i < minLength; i++)
            {
                result += firstArr[i] * secondArr[i];
            }

            int maxLength = Math.Max(firstArr.Length, secondArr.Length);

            char[] longestArr = maxLength == firstArr.Length ?
                firstArr :
                secondArr;

            for (int i = maxLength - 1; i >= minLength; i--)
            {
                result += longestArr[i];
            }

            Console.WriteLine(result);
        }
    }
}
