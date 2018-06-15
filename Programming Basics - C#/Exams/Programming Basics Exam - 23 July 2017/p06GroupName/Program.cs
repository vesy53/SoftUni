using System;

namespace p06GroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            char upperLetter = char.Parse(Console.ReadLine());
            char smallLetter1 = char.Parse(Console.ReadLine());
            char smallLetter2 = char.Parse(Console.ReadLine());
            char smallLetter3 = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = 'A'; i <= upperLetter; i++)
            {
                for (char j = 'a'; j <= smallLetter1; j++)
                {
                    for (char k = 'a'; k <= smallLetter2; k++)
                    {
                        for (char l = 'a'; l <= smallLetter3; l++)
                        {
                            for (int m = 0; m <= number; m++)
                            {
                                counter++;                               
                            }
                        }
                    }
                }
            }

            Console.WriteLine(counter - 1);
        }
    }
}
