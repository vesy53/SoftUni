using System;
using System.Collections.Generic;
using System.Linq;

namespace p07CountNumbers3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.Sort();

            List<int> specificNum = new List<int>();
            List<int> repeatedTime = new List<int>();

            bool isLastElementPrinted = false;   
            int count = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;

                    if (i == numbers.Count - 1)
                    {
                        specificNum.Add(numbers[i - 1]);
                        repeatedTime.Add(count);
                        count = 1;
                        isLastElementPrinted = true;
                    }
                }
                else
                {
                    specificNum.Add(numbers[i - 1]);
                    repeatedTime.Add(count);
                    count = 1;
                }
            }

            for (int i = 0; i < specificNum.Count; i++)
            {
                Console.WriteLine($"{specificNum[i]} -> {repeatedTime[i]}");
            }

            if (!isLastElementPrinted)
            {
                Console.WriteLine($"{numbers[numbers.Count - 1]} -> 1");
            }
        }
    }
}
