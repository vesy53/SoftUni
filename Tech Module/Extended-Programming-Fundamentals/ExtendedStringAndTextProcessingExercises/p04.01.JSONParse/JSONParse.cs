namespace p04._01.JSONParse
{
    using System;
    using System.Text;

    class JSONParse
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { "[{", "}]", "name:\"", "\",age:", ",grades:", "},{" },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < input.Length - 2; i += 3)
            {
                string name = input[i];
                string age = input[i + 1];
                string[] grades = input[i + 2]
                    .Split(new char[] { '[', ']', ',', ' ' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                builder.Append(
                        $"{name} : {age} -> ");

                if (grades.Length == 0)
                {
                    builder.Append(
                        $"None" + Environment.NewLine);
                }
                else
                {
                    builder.Append(
                        $"{string.Join(", ", grades)}" + 
                        Environment.NewLine);
                }
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
