namespace p07._01.SoftUniParty
{
    using System;
    using System.Collections.Generic;

    class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> vipInvited = new HashSet<string>();
            HashSet<string> regularInvited = new HashSet<string>();

            string input = Console.ReadLine();

            while (input.Equals("PARTY") == false)
            {
                if (input.Length == 8)
                {
                    if (char.IsDigit(input[0]))
                    {
                        vipInvited.Add(input);
                    }
                    else
                    {
                        regularInvited.Add(input);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                if (char.IsDigit(input[0]))
                {
                    vipInvited.Remove(input);
                }
                else
                {
                    regularInvited.Remove(input);
                }

                input = Console.ReadLine();
            }

            int count = vipInvited.Count + regularInvited.Count;

            Console.WriteLine(count);

            if (vipInvited.Count > 0)
            {
                Console.WriteLine(
                    string.Join(Environment.NewLine, vipInvited));
            }

            if (regularInvited.Count > 0)
            {
                Console.WriteLine(
                    string.Join(Environment.NewLine, regularInvited));
            }
        }
    }
}
