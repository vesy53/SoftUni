namespace p04._01.WinningTicket
{
    using System;
    using System.Text.RegularExpressions;

    class WinningTicket2
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

                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    Regex pattern = new Regex(@".*([@|#|$|^]{6,10}).*\1.*");

                    Match match = pattern.Match(currTicket);

                    if (match.Success)
                    {
                        int count = match.Groups[1].Length;
                        string symbol = match.Groups[1].Value;
                        symbol = symbol.Substring(0, 1);

                        if (count >= 6 && count <= 9)
                        {
                            Console.WriteLine(
                                $"ticket \"{currTicket}\" - {count}{symbol}");
                        }
                        else if (count == 10)
                        {
                            Console.WriteLine(
                                $"ticket \"{currTicket}\" - {count}{symbol} Jackpot!");
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
