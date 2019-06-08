namespace p09._01.SimpleTextEditor
{
    using System;
    using System.Collections.Generic;

    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string text = string.Empty;
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < number; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = commandArgs[0];

                switch (command)
                {
                    case "1":
                        string addString = commandArgs[1];

                        stack.Push(text);
                        text += addString;
                        break;
                    case "2":
                        int indexesPerDeleted = int.Parse(commandArgs[1]);

                        stack.Push(text);
                        int startIndex = text.Length - indexesPerDeleted;
                        text = text.Remove(startIndex);
                        break;
                    case "3":
                        int searcIndex = int.Parse(commandArgs[1]);

                        char takeElement = text[searcIndex - 1];
                        Console.WriteLine(takeElement);
                        break;
                    case "4":
                        text = stack.Pop();
                        break;
                }
            }
        }
    }
}
