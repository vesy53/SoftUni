using System;

namespace p08ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            bool isSymmetryc = true;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != words[words.Length - 1 - i])
                {
                    isSymmetryc = false;
                }
            }

            if (isSymmetryc)
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
