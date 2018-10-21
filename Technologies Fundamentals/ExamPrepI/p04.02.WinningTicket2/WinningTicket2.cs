namespace p04._02.WinningTicket2
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

            Regex pattern = new Regex(@"([@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10})");

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

                    Match matchLeftHalf = pattern.Match(leftHalf);
                    Match matchRightHalf = pattern.Match(rightHalf);

                    if ((matchLeftHalf.Success && matchRightHalf.Success) &&
                        (matchLeftHalf.Value[0] == matchRightHalf.Value[0]))
                    {
                        string left = matchLeftHalf.Value;
                        string right = matchRightHalf.Value;

                        char symbol = left[0];

                        if (left.Length == 10 && right.Length == 10)
                        {
                            Console.WriteLine(
                                $"ticket \"{currTicket}\" - 10{symbol} Jackpot!");
                        }
                        else
                        {
                            int minLength = Math.Min(left.Length, right.Length);

                            Console.WriteLine(
                                $"ticket \"{currTicket}\" - {minLength}{symbol}");
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
