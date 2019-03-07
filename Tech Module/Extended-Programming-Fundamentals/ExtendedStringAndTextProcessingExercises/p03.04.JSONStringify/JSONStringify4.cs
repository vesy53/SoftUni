namespace p03._04.JSONStringify
{
    using System;
    using System.Text;

    class JSONStringify4
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            while (input.Equals("stringify") == false)
            {
                string[] inputTokens = input
                    .Split(new string[] { " : ", " ->" },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = inputTokens[0];
                string age = inputTokens[1];
                string[] grades = new string[] { };

                if (inputTokens.Length > 2)
                {
                    grades = inputTokens[2]
                        .Split(new string[] { ",", " " },
                           StringSplitOptions
                           .RemoveEmptyEntries);
                }

                if (result.Length != 0)
                {
                    result.Append(",");
                }

                result.Append("{");
                result.Append(
                    string.Format("name:\"{0}\",age:{1},grades:[{2}]",
                        name, age, string.Join(", ", grades)));
                result.Append("}");

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", result.ToString());
        }
    }
}
