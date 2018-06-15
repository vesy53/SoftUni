using System;

namespace p06SelectionOrArtwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());

            int selection = 0;
            int artwork = 0;
            bool isCounter = false;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        selection = i + j + k;

                        if (selection == controlNum && i < j && j < k)
                        {
                            Console.WriteLine
                                ($"{i} + {j} + {k} = {selection}");
                            isCounter = true;
                        }                     
                    
                        artwork = i * j * k;

                        if (artwork == controlNum && i > j && j > k)
                        {
                            Console.WriteLine(
                                $"{i} * {j} * {k} = {artwork}");
                            isCounter = true;
                        }
                    }
                }
            }

            if (!isCounter)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
