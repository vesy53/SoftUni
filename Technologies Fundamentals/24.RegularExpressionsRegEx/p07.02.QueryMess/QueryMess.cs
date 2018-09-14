namespace p07._02.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class QueryMess
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"([^&=?]*)=([^&=]*)");
            string secPattern = @"((%20|\+)+)";

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                MatchCollection matches = pattern.Matches(input);
                var data = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string key = match.Groups[1].Value;
                    string value = match.Groups[2].Value;

                    key = Regex.Replace(key, secPattern, " ").Trim();
                    value = Regex.Replace(value, secPattern, " ").Trim();

                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, new List<string>());
                    }

                    data[key].Add(value);
                }

                foreach (var item in data)
                {
                    string key = item.Key;
                    List<string> values = item.Value;

                    Console.Write(
                        $"{key}=[{string.Join(", ", values)}]");
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
