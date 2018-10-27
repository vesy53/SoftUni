namespace p02._01.MatchPhoneNumber
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\+359([ -])2\1\d{3}\1\d{4}\b");

            string phoneNumbers = Console.ReadLine();

            MatchCollection matchPhoneNums = pattern.Matches(phoneNumbers);

            StringBuilder builder = new StringBuilder();

            foreach (Match phoneNum in matchPhoneNums)
            {
                builder.Append(phoneNum + ", ");
            }

            builder.Remove(builder.Length - 2, 2);

            Console.WriteLine(builder.ToString());
        }
    }
}
