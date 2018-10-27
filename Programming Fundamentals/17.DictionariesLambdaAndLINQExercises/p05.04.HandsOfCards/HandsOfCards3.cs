using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards3
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> playersHands = new Dictionary<string, List<string>>();
        string[] inputString = Console.ReadLine()
            .Split(':')
            .ToArray();

        while (inputString[0] != "JOKER")
        {
            string name = inputString[0];
            List<string> cards = inputString[1]
                .Split(new char[] { ' ', ',' }
                    , StringSplitOptions
                    .RemoveEmptyEntries)
                    .Distinct()
                    .ToList();

            if (playersHands.ContainsKey(name) == false)
            {
                playersHands.Add(name, cards);
            }
            else
            {
                playersHands[name].AddRange(cards);
            }

            inputString = Console.ReadLine()
                .Split(':')
                .ToArray();
        }

        foreach (var players in playersHands)
        {
            var totalCards = playersHands[players.Key].Distinct().ToList();

            int totalSum = CalculateCardsSum(totalCards);

            Console.WriteLine($"{players.Key}: {totalSum}");
        }
    }

    static int CalculateCardsSum(List<string> totalCards)
    {
        int total = 0;        

        foreach (var cards in totalCards)
        {
            string powerStr = string.Empty;

            if (cards.Length == 3)
            {
                powerStr = cards[0].ToString() + cards[1].ToString();
            }
            else
            {
                powerStr = cards[0].ToString();
            }

            string typeStr = cards[cards.Length - 1].ToString();

            int power = FindPowerAsInteger(powerStr);
            int type = FindTypeAsInteger(typeStr);

            total += power * type;
        }

        return total;
    }

    static int FindTypeAsInteger(string typeStr)
    {
        int type = 0;

        switch (typeStr)
        {
            case "S":
                type = 4;
                break;
            case "H":
                type = 3;
                break;
            case "D":
                type = 2;
                break;
            case "C":
                type = 1;
                break;
        }

        return type;
    }

    static int FindPowerAsInteger(string powerStr)
    {
        int power = 0;

        switch (powerStr)
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
                power = int.Parse(powerStr);
                break;
        }

        return power;
    }
}

