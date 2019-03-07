using System;

namespace p08SMSTyping2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string findLetters = "";

            for (int i = 0; i < number; i++)
            {
                int textMessage = int.Parse(Console.ReadLine());

                int numLength = textMessage.ToString().Length;
                int mainDigit = textMessage % 10;
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = (offset + numLength - 1);
                letterIndex += 97;

                if (letterIndex == 91)
                {
                    letterIndex -= 59;
                }

                char letter = (char)(letterIndex);
                findLetters += letter;
            }

            Console.WriteLine(findLetters);
        }
    }
}
