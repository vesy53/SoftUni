using System;
using System.Collections.Generic;
using System.Linq;

namespace p08CondenseArrayToNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = numArr.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < numArr.Count; j++)
                {
                    if (j + 1 < numArr.Count)
                    {
                        numArr[j] += numArr[j + 1];
                    }
                    else
                    {
                        numArr.RemoveRange(numArr.Count - 1, 1);
                    }
                }
            }

            Console.WriteLine(numArr[0]);
        }
    }
}
