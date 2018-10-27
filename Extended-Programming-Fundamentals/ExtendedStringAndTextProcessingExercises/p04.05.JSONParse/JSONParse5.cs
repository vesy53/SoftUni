namespace p04._05.JSONParse
{
    using System;
    using System.Text.RegularExpressions;

    class JSONParse5
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patter = @"name:""([A-z]{1,})"",age:([0-9]*),grades:\[([0-9, ]*)\]}";

            var matches = Regex.Matches(input, patter);

            foreach (Match match in matches)
            {
                string studentName = match.Groups[1].Value;
                string age = match.Groups[2].Value;
                string grades = match.Groups[3].Value;

                Console.Write($"{studentName} : {age} -> ");

                if (grades == string.Empty)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine(grades);
                }
            }
        }
    }
}
