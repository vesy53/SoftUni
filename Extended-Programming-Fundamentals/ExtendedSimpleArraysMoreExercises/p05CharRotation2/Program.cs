using System;
using System.Linq;

namespace p05CharRotation2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine()
                .ToCharArray();
            int[] numArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] % 2 == 0)
                {
                    text[i] -= (char)numArr[i];
                }
                else if (numArr[i] % 2 != 0)
                {
                    text[i] += (char)numArr[i];
                }
            }

            Console.WriteLine(string.Join("", text));
        }
    }
}
