namespace p06._01.EmailStatistics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class EmailStatistics
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var emailsData = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                string email = Console.ReadLine();

                Regex pattern = new Regex(@"^(?<name>[A-Za-z]{5,})@(?<domain>[a-z]{3,}(\.com|\.bg|\.org))$");
                //Regex pattern = new Regex(@"^(?<name>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.(com|bg|org))$");

                MatchCollection matchesEmail = pattern.Matches(email);

                foreach (Match matchEmail in matchesEmail)
                {
                    string username = matchEmail.Groups["name"].Value;
                    string domain = matchEmail.Groups["domain"].Value;

                    if (!emailsData.ContainsKey(domain))
                    {
                        emailsData.Add(domain, new List<string>());
                    }

                    if (!emailsData[domain].Contains(username))
                    {
                        emailsData[domain].Add(username);
                    }
                }
            }

            emailsData = emailsData
                .OrderByDescending(x => x.Value.Count())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var emailData in emailsData)
            {
                string domain = emailData.Key;
                List<string> username = emailData.Value;

                Console.WriteLine($"{domain}:");

                foreach (var user in username)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
