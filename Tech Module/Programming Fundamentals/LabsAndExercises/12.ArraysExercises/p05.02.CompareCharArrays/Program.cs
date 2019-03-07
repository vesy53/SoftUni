using System;
using System.Linq;

namespace p05CompareCharArrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters1 = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();
            char[] letters2 = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            bool isEqual = false;

            for (int i = 0; i < letters1.Length && i < letters2.Length; i++)
            {
                if (letters1[i] < letters2[i])
                {
                    isEqual = true;
                    PrintArray(letters1, letters2);
                    break;
                }
                else if (letters1[i] > letters2[i])
                {
                    isEqual = true;
                    PrintArray(letters2, letters1);
                    break;
                }
                else
                {
                    break;
                }
            }

            if (isEqual == false)
            {
                if (letters1.Length <= letters2.Length)
                {
                    PrintArray(letters1, letters2);
                }
                else
                {
                    PrintArray(letters2, letters1);
                }
            }
        }

        static void PrintArray(char[] letters1, char[] letters2)
        {
            Console.WriteLine(string.Join("", letters1));
            Console.WriteLine(string.Join("", letters2));
        }
    }
}
