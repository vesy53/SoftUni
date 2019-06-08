namespace p01._03.ReverseStrings
{
    using System;
    using System.Collections.Generic;

    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char @char in inputStr)
            {
                stack.Push(@char);
            }

            while (stack.Count != 0)
            {
                char currentLetter = stack.Peek();

                stack.Pop();

                Console.Write(currentLetter);
            }

            Console.WriteLine();
        }
    }
}
