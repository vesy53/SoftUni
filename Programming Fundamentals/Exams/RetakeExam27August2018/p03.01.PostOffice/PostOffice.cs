namespace p03._01.PostOffice
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class PostOffice
    {
        static void Main(string[] args)
        {
            string[] message = Console.ReadLine()
                .Split('|');

            string firstPart = message[0];
            string secondPart = message[1];
            string thirdPart = message[2];

            Regex firstPattern = new Regex(@"([#$%\*&])(?<letter>[A-Z]+)\1");
            //Regex firstPattern = new Regex(@"(?<symbols>[#$%\*&])(?<letter>[A-Z]+)\k<symbols>");

            Match matchLetters = firstPattern.Match(firstPart);

            if (matchLetters.Success)
            {
                string letters = matchLetters.Groups["letter"].Value;

                foreach (char letter in letters)
                {
                    char currLetter = letter;

                    int numLetter = Convert.ToInt32(currLetter);

                    Regex secondPattern = new Regex($@"{numLetter}" + @":(?<length>[0-9]{2})");

                    Match matchLength = secondPattern.Match(secondPart);

                    int length = 0;

                    if (matchLength.Success)
                    {
                        length = int.Parse(matchLength.Groups["length"].Value);
                    }

                    if (length >= 1 && length <= 20)
                    {
                        Regex thirdPattern = new Regex($@"^(?<word>[{currLetter}]\S{{{length}}})$");
                        //Regex thirdPattern = new Regex($@"^(?<word>[{currLetter}][^\s]{{{length}}})$");

                        string[] third = thirdPart
                            .Split();

                        for (int i = 0; i < third.Length; i++)
                        {
                            string current = third[i];

                             Match matchWord = thirdPattern.Match(current);

                             if (matchWord.Success)
                             {
                                 string word = matchWord.Groups["word"].Value;

                                 Console.WriteLine(word);
                                 break;
                             }
                        }
                    }                   
                }
            }
        }
    }
}
