namespace p01._01.DataTransfer
{
    using System;
    using System.Text.RegularExpressions;

    class DataTransfer
    {
        static int totalMB;

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Regex regex = new Regex(
                @"s:(?<sender>[^;]+);r:(?<receiver>[^;]+);m--(?<message>""[A-Za-z ]+"")");

            totalMB = 0;

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string sender = match.Groups["sender"].Value;
                    string receiver = match.Groups["receiver"].Value;
                    string message = match.Groups["message"].Value;

                    string senderName = TakeName(sender);
                    string receiverName = TakeName(receiver);

                    Console.WriteLine(  
                        $"{senderName} says {message} to {receiverName}");
                }
            }

            Console.WriteLine($"Total data transferred: {totalMB}MB");
        }

        private static string TakeName(string name)
        {
            string searchName = string.Empty;

            foreach (char symbol in name)
            {
                if (char.IsDigit(symbol))
                {
                    totalMB += int.Parse(symbol.ToString());
                }
                else if (char.IsLetter(symbol) || 
                    char.IsSeparator(symbol))
                {
                    searchName += symbol;
                }
            }

            return searchName;
        }
    }
}
