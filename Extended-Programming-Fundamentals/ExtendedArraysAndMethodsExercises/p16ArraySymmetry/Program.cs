using System;

namespace p16ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            bool isSymmetry = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    isSymmetry = false;
                }
            }

            Console.WriteLine(isSymmetry ? "Yes" : "No");
        }
    }
}
