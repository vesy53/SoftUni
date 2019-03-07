using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards1
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
        string[] hands = Console.ReadLine()
            .Split(new char[] { ':' },
            StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string names = "";
        List<string> cards = new List<string>();

        while (hands[0] != "JOKER")
        {
            names = hands[0];
            cards = hands[1]
                .Split(new char[] { ' ', ',' }
                    , StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
            cards = cards
                .Distinct()
                .ToList();

            if (players.ContainsKey(names) == false)
            {
                players.Add(names, cards);
            }
            else
            {
                players[names].AddRange(cards);
                players[names] = players[names].Distinct().ToList();
            }

            hands = Console.ReadLine()
                .Split(new char[] { ':' }
                    , StringSplitOptions
                    .RemoveEmptyEntries)
                .ToArray();
        }

        int multipe = 0;
        int mainValue = 0;
        int sum = 0;

        foreach (var player in players)
        {
            foreach (var card in player.Value)
            {
                switch (card[card.Length - 1])
                {
                    case 'S':
                        multipe = 4;
                        break;
                    case 'H':
                        multipe = 3;
                        break;
                    case 'D':
                        multipe = 2;
                        break;
                    case 'C':
                        multipe = 1;
                        break;
                }

                string power = card.Remove(card.Length - 1, 1);

                switch (power)
                {
                    case "J":
                        mainValue = 11;
                        break;
                    case "Q":
                        mainValue = 12;
                        break;
                    case "K":
                        mainValue = 13;
                        break;
                    case "A":
                        mainValue = 14;
                        break;
                    default:
                        mainValue = int.Parse(power);
                        break;
                }

                sum += multipe * mainValue;
            }

            Console.WriteLine($"{player.Key}: {sum}");

            sum = 0;
        }
    }
}

