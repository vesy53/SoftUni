namespace p02._01.Placeholders
{
    using System;

    class Placeholders
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] inputTokens = input
                    .Split(new string[] { " -> " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string text = inputTokens[0];
                string[] elements = inputTokens[1]
                    .Split(new string[] { ", " },
                        StringSplitOptions
                        .RemoveEmptyEntries);


                for (int i = 0; i < elements.Length; i++)
                {
                    string currentElements = "{" + i + "}";

                    string element = elements[i];

                    text = text.Replace(currentElements, element);
                }

                Console.WriteLine(text);

                input = Console.ReadLine();
            }
        }
    }
}
