using System;
using System.Linq;

namespace p14EqualSequenceOfElementsInArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray()
                .Distinct();

            if (arr.Count() == 1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            //another method for print
            //Console.WriteLine(arr.Count() == 1 ? "Yes" : "No");
        }
    }
}
