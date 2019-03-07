namespace p07._01.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class QueryMess
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"(?<key>[^&?]+)=(?<value>[^&?]+)"
            );

            string input = Console.ReadLine();
            
            while (input.Equals("END") == false)
            {
                MatchCollection matches = pattern.Matches(input);
                var data = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string key = match.Groups["key"].Value;
                    string value = match.Groups["value"].Value;

                    key = Regex.Replace(key, @"(%20|\+)+", " ").Trim();
                    value = Regex.Replace(value, @"(%20|\+)+", " ").Trim();

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

                    Console.Write($"{key}=[{string.Join(", ", values)}]");
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }

        }
    }
}
