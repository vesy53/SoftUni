using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards4
{
    static void Main(string[] args)
    {
        Dictionary<string, int> points = new Dictionary<string, int>();
        Dictionary<string, string> playersHands = new Dictionary<string, string>();
        string[] inputString = Console.ReadLine()
            .Split(':');

        while (inputString[0] != "JOKER")
        {
            string name = inputString[0];

            if (playersHands.ContainsKey(name) == false)
            {
                playersHands.Add(name, inputString[1]);
            }
            else
            {
                playersHands[name] += inputString[1];
            }

            inputString = Console.ReadLine()
                .Split(':');
        }

        foreach (var item in playersHands)
        {
            List<string> cards = new List<string>();

            cards = item
                .Value
                .Split(new char[] { ' ', ',' }
                    , StringSplitOptions
                    .RemoveEmptyEntries)
                .Distinct()
                .ToList();

            int total = 0;

            foreach (var card in cards)
            {
                total += CalculateCardsSum(card);
            }

            if (points.ContainsKey(item.Key) == false)
            {
                points.Add(item.Key, total);
            }
            else
            {
                points[item.Key] += total;
            }
        }

        foreach (var point in points)
        {
            Console.WriteLine($"{point.Key}: {point.Value}");
        }
    }

    static int CalculateCardsSum(string card)
    {
        string power = card[0].ToString();
        string type = card[card.Length - 1].ToString();

        if (power == "1")
        {
            power = "10";
        }

        int powerAsNumber = 0;
        int typeAsNumber = 0;
        bool numPower = int.TryParse(power, out powerAsNumber);  //За цифровите стойности

        if (numPower == false)
        {
            switch (power)
            {
                case "J":
                    powerAsNumber = 11;
                    break;
                case "Q":
                    powerAsNumber = 12;
                    break;
                case "K":
                    powerAsNumber = 13;
                    break;
                case "A":
                    powerAsNumber = 14;
                    break;
            }
        }

        switch (type)
        {
            case "S":
                typeAsNumber = 4;
                break;
            case "H":
                typeAsNumber = 3;
                break;
            case "D":
                typeAsNumber = 2;
                break;
            case "C":
                typeAsNumber = 1;
                break;
        }

        int totalSum = powerAsNumber * typeAsNumber;

        return totalSum;
    }
}

