using System;
using System.Linq;

namespace p05CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();           
            int[] numArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            char[] symbol = text.ToCharArray();
            string result = string.Empty;

            for (int i = 0; i < numArr.Length; i++)
            {
                int sum = 0;

                if (numArr[i] % 2 == 0)
                {
                    sum = symbol[i] - numArr[i];
                }
                else if (numArr[i] % 2 != 0)
                {
                    sum = symbol[i] + numArr[i];
                }

                char charLetterASCII = (char)(sum);
                result += charLetterASCII;
            }

            Console.WriteLine(result);
        }
    }
}
