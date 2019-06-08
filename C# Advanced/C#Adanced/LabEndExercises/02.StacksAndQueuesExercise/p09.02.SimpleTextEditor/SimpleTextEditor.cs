namespace p09._02.SimpleTextEditor
{
    using System;
    using System.Collections.Generic;

    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();
            string text = string.Empty;

            stack.Push(text);

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "1":
                        string addText = tokens[1];

                        text += addText;
                        stack.Push(text);
                        break;
                    case "2":
                        int elementsPerDeleted = int.Parse(tokens[1]);

                        text = text.Substring(0, text.Length - elementsPerDeleted);
                        stack.Push(text);
                        break;
                    case "3":
                        int searcIndex = int.Parse(tokens[1]);

                        char searchElement = text[searcIndex - 1];
                        Console.WriteLine(searchElement);
                        break;
                    case "4":
                        stack.Pop();
                        text = stack.Peek();
                        break;
                }
            }
        }
    }
}