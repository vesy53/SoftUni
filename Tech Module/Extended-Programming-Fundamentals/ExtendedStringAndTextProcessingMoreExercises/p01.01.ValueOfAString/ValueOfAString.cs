namespace p01._01.ValueOfAString
{
    using System;

    class ValueOfAString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();

            int sum = 0;

            foreach (var letter in text)
            {
                char currentLetter = letter;

                if (command == "LOWERCASE" &&
                    char.IsLower(currentLetter))
                {
                    sum += currentLetter;
                }
                else if (command == "UPPERCASE" &&
                    char.IsUpper(currentLetter))
                {
                    sum += currentLetter;
                }              
            }

            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
