namespace p04._01.CharacterMultiplier
{
    using System;

    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            char[] firstArr = input[0].ToCharArray();
            char[] secondArr = input[1].ToCharArray();

            int min = Math.Min(firstArr.Length, secondArr.Length);
            int multiplied = 0;
            int result = 0;

            for (int i = 0; i < min; i++)
            {
                int currentFirstInt = firstArr[i];
                int currentSecondInt = secondArr[i];

                multiplied = currentFirstInt * currentSecondInt;

                result += multiplied;
            }

            int max = Math.Max(firstArr.Length, secondArr.Length);

            for (int i = min; i < max; i++)
            {
                if (firstArr.Length > secondArr.Length)
                {
                    result += firstArr[i];
                }
                else
                {
                    result += secondArr[i];
                }

                //or another method per sum
                //try
                //{
                //    result += firstArr[i];
                //}
                //catch
                //{
                //    result += secondArr[i];
                //}
            }

            Console.WriteLine(result);
        }
    }
}
