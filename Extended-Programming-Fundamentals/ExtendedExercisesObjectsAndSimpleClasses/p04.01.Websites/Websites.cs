using System;
using System.Collections.Generic;
using System.Linq;

class Websites
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<Website> websiteList = new List<Website>();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { " | ", "," },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string host = inputTokens[0];
            string domain = inputTokens[1];
            List<string> queries = new List<string>();

            for (int i = 2; i < inputTokens.Length; i++)
            {
                queries.Add(inputTokens[i]);
            };

            Website information = new Website
            {
                Host = host,
                Domain = domain,
                Queries = queries
            };

            websiteList.Add(information);

            input = Console.ReadLine();
        }

        foreach (Website list in websiteList)
        {
            string host = list.Host;
            string domain = list.Domain;
            List<string> queriesList = list.Queries;

            if (queriesList.Count == 0)
            {
                Console.WriteLine($"https://www.{host}.{domain}");
            }
            else
            {
                Console.Write($"https://www.{host}.{domain}/query?=");

                string queriesHelper = String.Empty;

                for (int i = 0; i < queriesList.Count - 1; i++)
                {
                    queriesHelper += $"[{queriesList[i]}]&";
                }

                queriesHelper += $"[{queriesList[queriesList.Count - 1]}]";

                Console.WriteLine(queriesHelper);
            }
        }
    }
}

class Website 
{
    public string Host { get; set; }
    public string Domain { get; set; }
    public List<string> Queries { get; set; }
}
