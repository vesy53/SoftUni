namespace p04._04.JSONParse
{
    using System;

    class JSONParse4
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = input.Substring(2, input.Length - 2 - 2);

            string[] tokens = input
                .Split(new string[] { "},{" },
                       StringSplitOptions
                       .RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                string[] properties = token
                    .Split(new string[] { "name:\"", "\",age:", ",grades:" },
                           StringSplitOptions
                           .RemoveEmptyEntries);

                string name = properties[0];
                string age = properties[1];
                string grades = properties[2]
                    .Substring(1, properties[2].Length - 2);

                if (grades == string.Empty)
                {
                    grades = "None";
                }

                Console.WriteLine($"{name} : {age} -> {grades}");
            }
        }
    }
}
