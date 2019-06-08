namespace p01._01.ReverseString
{
    using System;
    using System.Collections.Generic;

    class ReverseString
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < inputStr.Length; i++)
            {
                char currentLetter = inputStr[i];

                stack.Push(currentLetter);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
