namespace p04._02.CubicMessages
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class CubicMessages2
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            string input = Console.ReadLine();

            while (input.Equals("Over!") == false)
            {
                int messageLenght = int.Parse(Console.ReadLine());

                Regex pattern = new Regex($@"^\d+([A-Za-z]{{{messageLenght}}})[^A-Za-z]*$");
                Match match = pattern.Match(input);

                if (match.Success)
                {
                    char[] indexes = input.Where(x => char.IsDigit(x)).ToArray();
                    string currentMessage = match.Groups[1].Value;
                    string code = string.Empty;

                    for (int i = 0; i < indexes.Count(); i++)
                    {
                        int currentIndex = (int)char.GetNumericValue(indexes[i]);

                        if (currentIndex < 0 || currentIndex >= currentMessage.Length)
                        {
                            code += " ";
                        }
                        else
                        {
                            code += currentMessage[currentIndex];
                        }
                    }

                    result.AppendLine($"{currentMessage} == {code}");
                }

                input = Console.ReadLine();
            }

            Console.Write(result);
        }
    }
}
