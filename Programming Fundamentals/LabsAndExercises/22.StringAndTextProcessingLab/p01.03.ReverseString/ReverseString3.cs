namespace p01._03.ReverseString
{
    using System;
    using System.Linq;

    class ReverseString3
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            string reversed= string.Join(
                string.Empty, 
                inputStr
                .ToCharArray()
                .Reverse());

            Console.WriteLine(reversed);
        }
    }
}
