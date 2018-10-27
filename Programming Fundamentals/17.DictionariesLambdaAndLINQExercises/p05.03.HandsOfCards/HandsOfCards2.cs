using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards2
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> playersCard = new Dictionary<string, List<string>>();
        List<string> input = Console.ReadLine()
            .Split(':')
            .ToList();

        List<string> cards = new List<string>();

        while (input[0].Equals("JOKER") == false)
        {
            string name = input[0];
            cards = input[1].Split(new char[] { ' ', ',' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .Distinct()
                .ToList();

            if (!playersCard.ContainsKey(name))
            {
                playersCard.Add(name, cards);
            }
            else
            {
                playersCard[name].AddRange(cards);
                playersCard[name] = playersCard[name].Distinct().ToList();
            }

            input = Console.ReadLine()
                .Split(':')
                .ToList();
        }

        foreach (var player in playersCard)
        {
            int total = 0;

            foreach (var p in player.Value)
            {
                total += CardsSum(p);
            }

            Console.WriteLine($"{player.Key}: {total}");
        }
    }

    static int CardsSum(string p)
    {
        int type = 0;
        int power = 0;
        int total = 0;

        switch (p.Last())
        {
            case 'S':
                type = 4;
                break;
            case 'H':
                type = 3;
                break;
            case 'D':
                type = 2;
                break;
            case 'C':
                type = 1;
                break;
        }

        string powerCard = p.Remove(p.Length - 1, 1);

        switch (powerCard)
        {
            case "J":
                power = 11;
                break;
            case "Q":
                power = 12;
                break;
            case "K":
                power = 13;
                break;
            case "A":
                power = 14;
                break;
            default:
                power = int.Parse(powerCard);
                break;
        }

        total += power * type;

        return total;
    }
}

