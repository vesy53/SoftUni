using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> handsOfCards = new Dictionary<string, List<string>>();
        string input = Console.ReadLine();

        while (input.Equals("JOKER") == false)
        {
            string[] playerAndCards = input.Split(':');

            string name = playerAndCards[0];
            string[] cards = playerAndCards[1]
                .Split(new char[] { ',', ' ' }
                , StringSplitOptions
                .RemoveEmptyEntries);

            if (!handsOfCards.ContainsKey(name))
            {
                handsOfCards.Add(name, new List<string>());
            }

            handsOfCards[name].AddRange(cards);  

            input = Console.ReadLine();
        }

        foreach (var hands in handsOfCards)
        {
            string name = hands.Key;
            int totalSum = 0;

            List<string> handsCard = new List<string>();

            handsCard = hands.Value.Distinct().ToList();

            foreach (var hand in handsCard)
            {
                int power = 0;
                int type = 0;

                switch (hand.Remove(hand.Length - 1, 1))
                {
                    case "2":
                        power = 2;
                        break;
                    case "3":
                        power = 3;
                        break;
                    case "4":
                        power = 4;
                        break;
                    case "5":
                        power = 5;
                        break;
                    case "6":
                        power = 6;
                        break;
                    case "7":
                        power = 7;
                        break;
                    case "8":
                        power = 8;
                        break;
                    case "9":
                        power = 9;
                        break;
                    case "10":
                        power = 10;
                        break;
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
                }

                char lastLetter = hand[hand.Length - 1];

                switch (lastLetter)
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

                totalSum += power * type;
            }

            Console.WriteLine($"{name}: {totalSum}");
        }
    }
}

