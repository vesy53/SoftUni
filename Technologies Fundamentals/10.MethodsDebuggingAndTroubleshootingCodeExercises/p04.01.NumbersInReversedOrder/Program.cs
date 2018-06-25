using System;

namespace p04NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            Console.WriteLine(ReverseString(num));
        }

        static string ReverseString(string num)
        {
            char[] arr = num.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }
}
