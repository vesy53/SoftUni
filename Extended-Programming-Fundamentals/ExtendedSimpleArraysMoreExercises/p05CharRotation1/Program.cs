using System;
using System.Linq;
using System.Text;

namespace p05CharRotation1
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

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < numArr.Length; i++)
            {
                int currentNum = numArr[i];

                int charInt = currentNum % 2 == 0 ?
                    text[i] - currentNum :
                    text[i] + currentNum;

                result.Append((char)charInt);
            }

            Console.WriteLine(result);
        }
    }
}
