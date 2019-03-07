using System;
using System.Collections.Generic;
using System.Linq;

namespace p02AppendLists4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<string> result = new List<string>();

            foreach (var i in input)
            {
                List<string> nums = i
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                foreach (var num in nums)
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
