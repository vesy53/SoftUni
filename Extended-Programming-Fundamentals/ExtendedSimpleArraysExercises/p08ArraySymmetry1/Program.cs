using System;
using System.Linq;

namespace p08ArraySymmetry1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            string[] reversArr = words.ToArray();
            Array.Reverse(reversArr);
            bool isSymmetric = true;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != reversArr[i])
                {
                    isSymmetric = false;
                }
            }

            if (isSymmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
