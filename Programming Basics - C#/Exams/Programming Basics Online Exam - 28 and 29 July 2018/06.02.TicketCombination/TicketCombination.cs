namespace _06._02.TicketCombination
{
    using System;

    class TicketCombination
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int count = 0;

            for (char i = 'B'; i <= 'L'; i++)
            {
                for (char j = 'f'; j >= 'a'; j--)
                {
                    for (char k = 'A'; k <= 'C'; k++)
                    {
                        for (int l = 1; l < 11; l++)
                        {
                            for (int m = 10; m >= 1; m--)
                            {
                                int numLetter = i;

                                if (numLetter % 2 == 0)
                                {
                                    count++;

                                    if (count == num)
                                    {
                                        int prize = i + j + k + l + m;

                                        Console.WriteLine(
                                            $"Ticket combination: {i}{j}{k}{l}{m}");
                                        Console.WriteLine($"Prize: {prize} lv.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
