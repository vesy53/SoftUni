namespace p06._01.FishStatistics
{
    using System;
    using System.Text.RegularExpressions;

    class FishStatistics
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(>*)<(\(+)(['\-x])>");

            string input = Console.ReadLine();

            MatchCollection fishes = pattern.Matches(input);

            if (fishes.Count == 0)
            {
                Console.WriteLine("No fish found.");
                return;
            }

            int count = 0;

            foreach (Match fish in fishes)
            {
                string tail = fish.Groups[1].Value;
                string body = fish.Groups[2].Value;
                string status = fish.Groups[3].Value;

                string tailType = string.Empty;
                string bodyType = string.Empty;
                string statusType = string.Empty;

                count++;

                if (tail.Length == 0)
                {
                    tailType = "  Tail type: None";
                }
                else if (tail.Length == 1)
                {
                    tailType = $"  Tail type: Short ({tail.Length * 2} cm)";
                }
                else if (tail.Length > 1 && tail.Length <= 5)
                {
                    tailType = $"  Tail type: Medium ({tail.Length * 2} cm)";
                }
                else if (tail.Length > 5)
                {
                    tailType = $"  Tail type: Long ({tail.Length * 2} cm)";
                }

                if (body.Length <= 5)
                {
                    bodyType = $"  Body type: Short ({body.Length * 2} cm)";
                }
                else if (body.Length > 5 && body.Length <= 10)
                {
                    bodyType = $"  Body type: Medium ({body.Length * 2} cm)";
                }
                else if (body.Length > 10)
                {
                    bodyType = $"  Body type: Long ({body.Length * 2} cm)";
                }

                switch (status)
                {
                    case "'":
                        statusType = "Awake";
                        break;
                    case "-":
                        statusType = "Asleep";
                        break;
                    case "x":
                        statusType = "Dead";
                        break;
                }

                Console.WriteLine($"Fish {count}: {fish.Value}");
                Console.WriteLine(tailType);
                Console.WriteLine(bodyType);
                Console.WriteLine($"Status: {statusType}");
            }
        }
    }
}
