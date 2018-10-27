using System;
using System.Linq;

namespace p16ArraySymmetry2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            var leftPart = text.Take(text.Length / 2).ToArray();
            var rightPart = text.Length % 2 == 0 ?
                text.Skip(text.Length / 2).ToArray() :
                text.Skip(text.Length / 2 - 1).ToArray();

            Array.Reverse(rightPart);

            bool isSymmetric = true;

            for (int i = 0; i < leftPart.Length; i++)
            {
                if (leftPart[i] != rightPart[i])
                {
                    isSymmetric = false;                   
                }
            }

            var result = isSymmetric ? "Yes" : "No";

            Console.WriteLine(result);
        }
    }
}
