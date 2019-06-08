namespace p04._01.MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> openingBrackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentElement = input[i];

                if (currentElement == '(')
                {
                    openingBrackets.Push(i);
                }
                else if (currentElement == ')')
                {
                    int startIndex = openingBrackets.Pop();
                    int length = i - startIndex + 1;

                    string result = input
                        .Substring(startIndex, length);

                    Console.WriteLine(result);
                }
            }
        }
    }
}
