namespace p03._01.TseamAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TseamAccount
    {
        static void Main(string[] args)
        {
            List<string> account = Console.ReadLine()
                .Split()
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("Play!") == false)
            {
                string[] tokens = input
                    .Split();
                string command = tokens[0];
                string game = tokens[1];

                switch (command)
                {
                    case "Install":
                        if (!account.Contains(game))
                        {
                            account.Add(game);
                        }
                        break;
                    case "Uninstall":
                        if (account.Contains(game))
                        {
                            account.Remove(game);
                        }
                        break;
                    case "Update":
                        if (account.Contains(game))
                        {
                            account.Remove(game);
                            account.Add(game);
                        }
                        break;
                    case "Expansion":                      
                        string[] gameExpansion = game
                            .Split('-');
                        string newGame = gameExpansion[0];
                        string expansion = gameExpansion[1];

                        if (account.Contains(newGame))
                        {
                            int index = account.IndexOf(newGame);

                            account.Insert(index + 1, newGame + ":" + expansion);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", account));
        }
    }
}
