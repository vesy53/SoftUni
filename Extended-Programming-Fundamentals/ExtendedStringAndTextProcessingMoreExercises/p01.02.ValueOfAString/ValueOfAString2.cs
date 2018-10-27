namespace p01._02.ValueOfAString
{
    using System;

    class ValueOfAString2
    {
        static void Main(string[] args)
        {
            char[] inputChars = Console.ReadLine()
                .ToCharArray();
            string command = Console.ReadLine();

            int sum = 0;

            foreach (var letter in inputChars)
            {
                if (command.Equals("LOWERCASE") &&
                    (letter >= 97 && letter <= 122))
                {
                    sum += letter;
                }
                else if (command.Equals("UPPERCASE") &&
                    (letter >= 65 && letter <= 90))
                {
                    sum += letter;
                }
            }

            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
