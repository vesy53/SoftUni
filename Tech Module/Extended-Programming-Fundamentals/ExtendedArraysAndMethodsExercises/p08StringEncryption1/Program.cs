using System;

namespace p08StringEncryption1
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
            string encryptedRresult = string.Empty;

            for (int i = 0; i < number; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                encryptedRresult += Encrypt(letter);
            }

            Console.WriteLine(encryptedRresult);
        }

        static string Encrypt(char letter)
        {
            string result = string.Empty;
            //Here, we convert char respresentation of letter to int representation
            int numLetterASCII = (int)letter;
            //Then, we convert the number we've found to string
            string letterASCII = ((int)letter).ToString();
            //Now could find the digits of ASCII code of the letter 
            //and therefore we can operate with the ASCII code of letter
            // -> example: Now we can find the first and the last digit of letter ASCII Code
            int letterASCIILength = letterASCII.Length;
            string firstDigitOfLetterASCII = letterASCII[0].ToString();
            string lastDigitOfLetterASCII = letterASCII[letterASCIILength - 1].ToString();
            //Here, we convert the first and last digit of ASCII code from string to int,
            //because we want to perform some arithmetic operations with the ASCII code 
            int firstDigitToInt = int.Parse(firstDigitOfLetterASCII);
            int lastDigitToInt = int.Parse(lastDigitOfLetterASCII);
            //Here: we have a new ASCII code, received by the arithmetic operations we've performed.
            //The new ASCII code is converted to a charecter
            char charBeforeFirstDigit = (char)(numLetterASCII + lastDigitToInt);
            char charAfterLastDigit = (char)(numLetterASCII - firstDigitToInt);
            //We form a result (for each letter seperately), as described 
            result = charBeforeFirstDigit + firstDigitOfLetterASCII + lastDigitOfLetterASCII + charAfterLastDigit;

            return result;
        }
    }
}
