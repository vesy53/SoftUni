namespace p03._03.Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    class Regexmon3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex didimon = new Regex(@"[^a-zA-Z\-]+");
            Regex bojomon = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");

            int round = 1;
            bool isHelper = false;

            while (isHelper != true)
            {
                if (round % 2 != 0)
                {
                    Match matchDidimon = didimon.Match(input);

                    if (matchDidimon.Success)
                    {
                        string value = matchDidimon.Value;
                        int remove = input.IndexOf(value);

                        input= input.Remove(0, value.Length + remove);

                        Console.WriteLine(matchDidimon.Value);
                    }
                    else
                    {
                        isHelper = true;
                    }
                }
                else if (round % 2 == 0)
                {
                    Match matchBojomon = bojomon.Match(input);

                    if (matchBojomon.Success)
                    {
                        string value = matchBojomon.Value;
                        int remove = input.IndexOf(value);

                        input = input.Remove(0, value.Length + remove);

                        Console.WriteLine(matchBojomon.Value);
                    }
                    else
                    {
                        isHelper = true;
                    }
                }

                round++;
            }
        }
    }
}
