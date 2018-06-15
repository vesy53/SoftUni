using System;

namespace p06LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char missLetter = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {                     
                        if (i != missLetter && j != missLetter && 
                            k != missLetter)
                        {
                            counter++;

                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
