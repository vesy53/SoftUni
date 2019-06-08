namespace p07._02.SoftUniParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> partyInvited = new HashSet<string>();

            string input = Console.ReadLine();

            while (input.Equals("PARTY") == false)
            {
                if (input.Length == 8)
                {
                    partyInvited.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                partyInvited.Remove(input);

                input = Console.ReadLine();
            }

            int count = partyInvited.Count;

            Console.WriteLine(count);

            /*foreach (string invited in partyInvited)
            {
                if (char.IsDigit(invited[0]))
                {
                    Console.WriteLine(invited);
                }
            }

            foreach (string invited in partyInvited)
            {
                if (!char.IsDigit(invited[0]))
                {
                    Console.WriteLine(invited);
                }
            } */

            var vipInviated = partyInvited
                .Where(p => char.IsDigit(p.ToCharArray()[0]));

            if (vipInviated.Count() != 0)
            {
                Console.WriteLine(
                    string.Join(Environment.NewLine, vipInviated));
            }

            var regularInviated = partyInvited
                .Where(p => !char.IsDigit(p.ToCharArray()[0]));

            if (regularInviated.Count() != 0)
            {
                Console.WriteLine(
                    string.Join(Environment.NewLine, regularInviated));
            }
        }
    }
}
