namespace p04._03.CharacterMultiplier
{
    using System;
    using System.Linq;

    class CharacterMultiplier3
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            string firstArr = text[0];
            string secondArr = text[1];

            int minLength = Math.Min(firstArr.Length, secondArr.Length);
            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += firstArr[i] * secondArr[i];
            }

            int differentLength = Math.Abs(firstArr.Length - secondArr.Length);

            if (firstArr.Length != secondArr.Length)
            {
                int convertStr = 0;

                if (firstArr.Length > secondArr.Length)
                {
                    string newLength = firstArr
                        .Substring(secondArr.Length, differentLength);

                    convertStr = newLength
                        .Sum(x => Convert.ToInt32(x));
                }
                else if (firstArr.Length < secondArr.Length)
                {
                    string newLength = secondArr
                        .Substring(firstArr.Length, differentLength);

                    convertStr = newLength
                        .Sum(x => Convert.ToInt32(x));
                }

                sum += convertStr;
            }

            Console.WriteLine(sum);
        }
    }
}
