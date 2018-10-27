using System;
using System.Linq;

namespace p16ArraySymmetry1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            string[] newText = text.ToArray();
            Array.Reverse(newText);

            bool isSymmetry = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != newText[i])
                {
                    isSymmetry = false;
                }
            }

            Console.WriteLine(isSymmetry ? "Yes" : "No");
        }
    }
}
