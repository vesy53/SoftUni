using System;

namespace p08StringEncryption2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            FindEncryptedChar(number);
        }

        static void FindEncryptedChar(int number)
        {
            string encryptedResult = string.Empty;

            for (int i = 0; i < number; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                encryptedResult += Encrypt(letter);
            }

            Console.WriteLine(encryptedResult);
        }

        static string Encrypt(char letter)
        {
            string result = string.Empty;
            // превръщане на char в int
            int number = letter;
            // превръщане на int в string
            string letterASCII = ((int)letter).ToString();

            string firstDigitLetter = letterASCII[0].ToString();
            string lastDigitLetter = letterASCII[letterASCII.Length - 1].ToString();
            // превръщане на string в int  
            int firstNum = int.Parse(firstDigitLetter);
            int lastNum = int.Parse(lastDigitLetter);
            // сумиране на int и превръщането му в char
            char charBeforeFirstDigit = (char)(number + lastNum);
            char charAfterLastDigit = (char)(number - firstNum);

            result = charBeforeFirstDigit + firstDigitLetter + lastDigitLetter + charAfterLastDigit;

            return result;
        }
    }
}
