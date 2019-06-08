namespace _06._01.Substitute
{
    using System;

    class Substitute
    {
        static void Main(string[] args)
        {
            int firstFirstNum = int.Parse(Console.ReadLine());
            int seconFirstNum = int.Parse(Console.ReadLine());
            int firstSecondNum = int.Parse(Console.ReadLine());
            int secondSecondNum = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = firstFirstNum; i <= 8; i++)
            {
                for (int j = 9; j >= seconFirstNum; j--)
                {
                    for (int k = firstSecondNum; k <= 8; k++)
                    {
                        for (int l = 9; l >= secondSecondNum; l--)
                        {
                            if ((i % 2 == 0 && j % 2 != 0) && 
                                (k % 2 == 0 && l % 2 != 0))
                            {

                                if (i == k && j == l)
                                {
                                    Console.WriteLine(
                                        "Cannot change the same player.");
                                }
                                else
                                {
                                    counter++;

                                    Console.WriteLine($"{i}{j} - {k}{l}");
                                }

                                if (counter == 6)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
