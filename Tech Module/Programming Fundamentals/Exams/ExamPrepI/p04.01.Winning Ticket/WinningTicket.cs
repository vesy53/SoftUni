namespace p04._01.WinningTicket
{
    using System;
    using System.Text.RegularExpressions;

    class WinningTicket
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new string[] { ", ", "\t", " " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            for (int i = 0; i < tickets.Length; i++)
            {
                string currTicket = tickets[i];

                if (currTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftHalf = currTicket.Substring(0, 10);
                    string rightHalf = currTicket.Substring(10);

                    Regex pattern = new Regex(@"([@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10})");

                    Match matchLeftHalf = pattern.Match(leftHalf);
                    Match matchRightHalf = pattern.Match(rightHalf);

                    if (matchLeftHalf.Success && matchRightHalf.Success)
                    {
                        int count = matchLeftHalf.Length;
                        string symbol = matchLeftHalf.Value;
                        string symbolOne = symbol.Substring(0, 1);

                        int countRight = matchRightHalf.Length;
                        string symbolRight = matchRightHalf.Value;
                        string symbolRightOne = symbolRight.Substring(0, 1);

                        if (symbolOne == symbolRightOne)
                        {
                            if (count == 10 && countRight == 10)
                            {
                                Console.WriteLine(
                                    $"ticket \"{currTicket}\" - {count}{symbolOne} Jackpot!");
                            }
                            else
                            {
                                int minLength = Math.Min(count, countRight);

                                Console.WriteLine(
                                $"ticket \"{currTicket}\" - {minLength}{symbolOne}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{currTicket}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currTicket}\" - no match");
                    }
                }
            }
        }
    }
}
