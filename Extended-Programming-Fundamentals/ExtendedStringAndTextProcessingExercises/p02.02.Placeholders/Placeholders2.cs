namespace p02._02.Placeholders
{
    using System;

    class Placeholders2
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

                int indexFirst = text.IndexOf("{");
                int indexLast = text.IndexOf("}");

                while (indexFirst != -1)
                {
                    int index = int.Parse
                    (
                        text
                            .Substring(indexFirst + 1, indexLast - indexFirst - 1)
                    );//0 v 1...

                    string oldStr = text
                        .Substring(indexFirst, indexLast - indexFirst + 1);//"{0}"...

                    if (index >= 0 && index < elements.Length)
                    {
                        text = text.Replace(oldStr, elements[index]);
                    }

                    indexFirst = text.IndexOf("{", indexFirst + 1);

                    if (indexFirst == -1)
                    {
                        break;
                    }

                    indexLast = text.IndexOf("}", indexLast + 1);
                }

                Console.WriteLine(text);

                input = Console.ReadLine();
            }
        }
    }
}
