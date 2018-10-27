namespace p08._02.LettersChangeNumbers
{
    using System;

    class LettersChangeNumbers2
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ' ', '\t' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            decimal total = 0.0m;

            for (int i = 0; i < text.Length; i++)
            {
                char firstLetter = char.Parse(text[i].Substring(0, 1));
                decimal number = decimal.Parse(text[i].Substring(1, text[i].Length - 2));
                char lastLetter = char.Parse(text[i].Substring(text[i].Length - 1));

                if (char.IsLower(firstLetter))
                {
                    number = number * (firstLetter - 96);
                }
                else if (char.IsUpper(firstLetter))
                {
                    number = number / (firstLetter - 64);
                }

                if (char.IsLower(lastLetter))
                {
                    number = number + (lastLetter - 96);
                }
                else if (char.IsUpper(lastLetter))
                {
                    number = number - (lastLetter - 64);
                }

                total += number;
            }

            Console.WriteLine($"{total:F2}");
        }
    }
}
