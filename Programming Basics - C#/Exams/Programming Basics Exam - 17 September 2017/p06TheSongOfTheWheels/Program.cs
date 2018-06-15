using System;

namespace p06TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());

            int counter = 0;
            int result = 0;
            bool isCount4 = false;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            int sum = i * j + k * m;

                            if (i < j && k > m && controlNum == sum)
                            {
                                counter++;

                                Console.Write($"{i}{j}{k}{m} ");

                                if (counter == 4)
                                {
                                    result = i * 1000 + j * 100 + k * 10 + m;
                                    isCount4 = true;
                                }
                            }                           
                        }
                    }
                }
            }

            Console.WriteLine();

            if (isCount4)
            {
                Console.WriteLine($"Password: {result}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
