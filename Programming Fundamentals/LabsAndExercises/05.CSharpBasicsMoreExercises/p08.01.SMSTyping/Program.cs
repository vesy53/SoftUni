using System;

namespace p08SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string words = "";

            for (int i = 0; i < number; i++)
            {
                int textMessage = int.Parse(Console.ReadLine());

                string letters = "";

                switch (textMessage)
                {
                    case 0:
                        letters = " ";
                        break;
                    case 2:
                        letters = "a";
                        break;
                    case 22:
                        letters = "b";
                        break;
                    case 222:
                        letters = "c";
                        break;
                    case 3:
                        letters = "d";
                        break;
                    case 33:
                        letters = "e";
                        break;
                    case 333:
                        letters = "f";
                        break;
                    case 4:
                        letters = "g";
                        break;
                    case 44:
                        letters = "h";
                        break;
                    case 444:
                        letters = "i";
                        break;
                    case 5:
                        letters = "j";
                        break;
                    case 55:
                        letters = "k";
                        break;
                    case 555:
                        letters = "l";
                        break;
                    case 6:
                        letters = "m";
                        break;
                    case 66:
                        letters = "n";
                        break;
                    case 666:
                        letters = "o";
                        break;
                    case 7:
                        letters = "p";
                        break;
                    case 77:
                        letters = "q";
                        break;
                    case 777:
                        letters = "r";
                        break;
                    case 7777:
                        letters += "s";
                        break;
                    case 8:
                        letters = "t";
                        break;
                    case 88:
                        letters = "u";
                        break;
                    case 888:
                        letters = "v";
                        break;
                    case 9:
                        letters = "w";
                        break;
                    case 99:
                        letters = "x";
                        break;
                    case 999:
                        letters = "y";
                        break;
                    case 9999:
                        letters = "z";
                        break;
                }

                words += letters;
            }

            Console.WriteLine(words);
        }
    }
}
