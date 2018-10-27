namespace p04._02.JSONParse
{
    using System;

    class JSONParse2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] studentTokens = input
                .Trim('[')
                .Split(new string[] { "},{" },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            for (int i = 0; i < studentTokens.Length; i++)
            {
                string student = studentTokens[i];

                student = student.Replace(":[]", ":[None]");
                student = student.Replace("]", string.Empty);
                student = student.Replace("{", string.Empty);
                student = student.Replace("}", string.Empty);
                student = student.Replace("name:\"", string.Empty);
                student = student.Replace("\",age:", " : ");
                student = student.Replace(",grades:[", " -> ");
                student = student.Replace("]}", string.Empty);

                Console.WriteLine(student);
            }
        }
    }
}
