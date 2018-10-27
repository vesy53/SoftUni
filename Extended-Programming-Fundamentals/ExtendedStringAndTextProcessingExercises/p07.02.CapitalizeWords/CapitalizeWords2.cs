namespace p07._02.CapitalizeWords
{
    using System;
    using System.Text;

    class CapitalizeWords2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] inputTokens = input
                    .Split(TakePunctuationArray(),
                        StringSplitOptions
                        .RemoveEmptyEntries);

                for (int i = 0; i < inputTokens.Length; ++i)
                {
                    inputTokens[i] = CapitalizeLetters(inputTokens[i]);
                }

                Console.WriteLine(string.Join(", ", inputTokens));

                input = Console.ReadLine();
            }
        }

        static char[] TakePunctuationArray()
        {
            return new char[] { ' ', ',', '.', '!', '?', '-', '+', ';', ':' };
        }

        static string CapitalizeLetters(string input)
        {
            StringBuilder builder = new StringBuilder(input);

            builder[0] = char.ToUpper(builder[0]);

            for (int i = 1; i < builder.Length; ++i)
            {
                builder[i] = char.ToLower(builder[i]);
            }

            return builder.ToString();
        }
    }
}
