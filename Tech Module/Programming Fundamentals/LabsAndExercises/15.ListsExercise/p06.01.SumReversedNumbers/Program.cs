namespace p06SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split()
                .ToList();

            int sum = 0;

            foreach (var num in numbers)
            {
                string newStr = new String(num
                    .ToString()
                    .Reverse()
                    .ToArray());

                sum += int.Parse(newStr);
            }
            
            Console.WriteLine(sum);
        }
    }
}
