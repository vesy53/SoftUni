namespace p02.HornetComm
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    class HornetComm
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string[] input = Console.ReadLine()
                .Split(new string[] { " <-> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            while (input[0].Equals("Hornet is Green") == false)
            {
                if (input.Length != 2)
                {
                    input = Console.ReadLine()
                        .Split(new string[] { " <-> " },
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    continue;
                }
                string firstQuery = input[0];
                string secondQuery = input[1];

                if (firstQuery.All(x => char.IsDigit(x)) &&
                    secondQuery.All(x => char.IsLetterOrDigit(x)))
                {
                    string reversed = new string
                    (
                        firstQuery
                        .ToCharArray()
                        .Reverse()
                        .ToArray()
                    );

                    messages.Add($"{reversed} -> {secondQuery}");
                }
                else if (firstQuery.All(x => !char.IsDigit(x)) &&
                    secondQuery.All(x => char.IsLetterOrDigit(x)))
                {
                    string reversedCase = ReversedCases(secondQuery);

                    broadcasts.Add($"{reversedCase} -> {firstQuery}");
                }


                input = Console.ReadLine()
                    .Split(new string[] { " <-> " },
                        StringSplitOptions
                        .RemoveEmptyEntries);
            }

            string broadcastResult = broadcasts.Count > 0 ?
                string.Join(Environment.NewLine, broadcasts) :
                "None";

            string messageResult = messages.Count > 0 ?
                string.Join(Environment.NewLine, messages) :
                "None";

            Console.WriteLine("Broadcasts:");
            Console.WriteLine($"{broadcastResult}");
            Console.WriteLine("Messages:");
            Console.WriteLine($"{messageResult}");
        }

        static string ReversedCases(string secondQuery)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < secondQuery.Length; i++)
            {
                char currentQuery = secondQuery[i];

                if (char.IsUpper(currentQuery))
                {      
                    result.Append(char.ToLower(currentQuery));
                }
                else if (char.IsLower(currentQuery))
                {
                    result.Append(char.ToUpper(currentQuery));
                }
                else
                {
                    result.Append(currentQuery);
                }
            }

            return result.ToString();
        }
    }
}
