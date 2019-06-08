namespace p01._02.ReverseStrings
{
    using System;
    using System.Collections.Generic;

    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            Stack<char> stack = new Stack<char>(inputStr);

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
