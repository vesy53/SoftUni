using System;
using System.Linq;

namespace p08ArraySymmetry2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            var leftPart = words.Take(words.Length / 2).ToArray();
            var rightPart = words.Length % 2 == 0 ?
                words.Skip(words.Length / 2).ToArray() :
                words.Skip(words.Length / 2 + 1).ToArray();

            Array.Reverse(rightPart);

            bool isSymmetric = true;

            for (int i = 0; i < leftPart.Length; i++)
            {
                if (leftPart[i] != rightPart[i])
                {
                    isSymmetric = false;
                    break;
                }
            }

            string result = isSymmetric ? "Yes" : "No";

            Console.WriteLine(result);
        }
    }
}
