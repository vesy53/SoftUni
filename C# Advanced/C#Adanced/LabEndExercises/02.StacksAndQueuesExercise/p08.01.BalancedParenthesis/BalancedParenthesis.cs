namespace p08._01.BalancedParenthesis
{
    using System;
    using System.Collections.Generic;

    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            string parantheses = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            bool isMatch = true;

            if (parantheses[0] == ']' ||
                parantheses[0] == ')' ||
                parantheses[0] == '}')
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < parantheses.Length; i++)
            {
                char element = parantheses[i];

                if (element == '(' ||
                    element == '{' ||
                    element == '[')
                {
                    stack.Push(element);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        isMatch = false;
                        break;
                    }

                    char closedElement = parantheses[i];
                    char stackElement = stack.Peek();

                    if (stackElement == '(' &&
                        closedElement == ')')
                    {
                        stack.Pop();
                    }
                    else if (stackElement == '[' &&
                        closedElement == ']')
                    {
                        stack.Pop();
                    }
                    else if (stackElement == '{' &&
                        closedElement == '}')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        isMatch = false;
                        break;
                    }
                }
            }

            if (isMatch)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}