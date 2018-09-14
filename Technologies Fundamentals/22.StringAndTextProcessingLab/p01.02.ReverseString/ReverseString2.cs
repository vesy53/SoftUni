namespace p01._02.ReverseString
{
    using System;
    using System.Linq;

    class ReverseString2
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string reversed = new string(text.Reverse().ToArray());

            Console.WriteLine(reversed);
        }
    }
}
