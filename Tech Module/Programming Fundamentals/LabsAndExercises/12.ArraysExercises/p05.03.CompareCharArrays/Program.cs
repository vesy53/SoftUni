using System;
using System.Linq;

namespace p05CompareCharArrays2
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

            int min = Math.Min(letters1.Length, letters2.Length);
            bool isEqual = true;

            for (int i = 0; i < min; i++)
            {
                if (letters1[i] == letters2[i])
                {
                    break;
                }
                else if (letters1[i] > letters2[i])
                {
                    isEqual = false;
                    break;
                }
                else if (letters1[i] < letters2[i])
                {
                    isEqual = false;
                    break;
                }
            }

            if ((isEqual) || (!isEqual && letters1.Length <= letters2.Length))
            {
                Console.WriteLine(string.Join("", letters1));
                Console.WriteLine(string.Join("", letters2));
            }
            else if(!isEqual && letters1.Length > letters2.Length)
            {
                Console.WriteLine(string.Join("", letters2));
                Console.WriteLine(string.Join("", letters1));
            }
        }
    }
}
