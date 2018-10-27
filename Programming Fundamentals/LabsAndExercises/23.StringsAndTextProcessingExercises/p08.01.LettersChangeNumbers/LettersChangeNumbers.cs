namespace p08._01.LettersChangeNumbers
{
    using System;

    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ' ', '\t' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string capitalLeters = "@ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            decimal total = 0.0m;
            
            for (int i = 0; i < text.Length; i++)
            {
                string firstLetter = text[i].Substring(0, 1);
                decimal num = decimal.Parse
                (
                    text[i]
                    .Substring(1, text[i].Length - 2)
                );
                string lastLetter = text[i]
                    .Substring(text[i].Length - 1, 1);

                char[] currentStr = text[i].ToCharArray();
                decimal sum = 0.0m;

                if (char.IsLower(currentStr[0]))
                {
                    int index = capitalLeters
                        .ToLower()
                        .IndexOf(firstLetter);

                    sum = num * index;
                }
                else if (char.IsUpper(currentStr[0]))
                {
                    int index = capitalLeters
                        .IndexOf(firstLetter);

                    sum = num / index;
                }

                if (char.IsLower(currentStr[currentStr.Length - 1]))
                {
                    int index = capitalLeters
                        .ToLower()
                        .IndexOf(lastLetter);

                    sum += index;
                }
                else if (char.IsUpper(currentStr[currentStr.Length - 1]))
                {
                    int index = capitalLeters
                        .IndexOf(lastLetter);

                    sum -= index;
                }

                total += sum;
            }

            Console.WriteLine($"{total:F2}");
        }
    }
}
