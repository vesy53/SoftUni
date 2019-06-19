namespace p02._01.RobotCommunication
{
    using System;
    using System.Text.RegularExpressions;

    class RobotCommunication
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(
                @"(?<first>[,|_])(?<letters>[A-Za-z]+)(?<digit>\d)");

            while (input.Equals("Report") == false)
            {
                MatchCollection matches = regex.Matches(input);

                string result = string.Empty;

                foreach (object item in matches)
                {
                    string element = item.ToString();

                    char firstElement = element[0];
                    int number = int
                        .Parse(element[element.Length - 1].ToString());

                    element = element
                        .Substring(1, element.Length - 2);

                    foreach (char letter in element)
                    {
                        char currentChar = letter;

                        if (firstElement == ',')
                        {
                            currentChar += Convert.ToChar(number);
                            result += currentChar;
                        }
                        else if (firstElement == '_')
                        {
                            currentChar -= Convert.ToChar(number);
                            result += currentChar;
                        }
                    }

                    result += " ";
                }

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
