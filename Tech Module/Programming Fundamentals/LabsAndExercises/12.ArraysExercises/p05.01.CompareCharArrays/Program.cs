using System;
using System.Linq;

namespace p05CompareCharArrays
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

            bool isEqual = true;
            int helper = 0;
            int min = Math.Min(letters1.Length, letters2.Length);

            for (int i = 0; i < min; i++)
            {
                if (letters1[i] != letters2[i])
                {
                    isEqual = false;

                    if (letters1[i] > letters2[i])
                    {
                        helper = 2;
                    }
                    else
                    {
                        helper = 1;
                    }
                }
            }

            if ((!isEqual && helper == 1) || (isEqual && letters1.Length <= letters2.Length))
            {
                Console.WriteLine(string.Join("", letters1));
                Console.WriteLine(string.Join("", letters2));
            }
            else if ((!isEqual && helper == 2) || 
                (isEqual && letters1.Length > letters2.Length))
            {
                Console.WriteLine(string.Join("", letters2));
                Console.WriteLine(string.Join("", letters1));
            }
        }
    }
}
