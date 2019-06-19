namespace p03._01.NumberWars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class NumberWars   //70/100
    {    
        const int MaxCounter = 1_000_000;

        static void Main(string[] args)
        {
            Queue<string> firstAllCards = new Queue<string>(Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries));
            Queue<string> secondAllCards = new Queue<string>(Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries));

            int turnsCounter = 0;
            bool gameOver = false;

            while (turnsCounter < MaxCounter &&
                firstAllCards.Count > 0 &&
                secondAllCards.Count > 0 &&
                !gameOver)
            {
                turnsCounter++;
                string firstCard = firstAllCards.Dequeue();
                string secondCard = secondAllCards.Dequeue();
                // int compareResult = GetNumber(firstCard).CompareTo(GetNumber(secondCard)); => return -1, 0 or 1
                if (GetNumber(firstCard) > GetNumber(secondCard))
                {
                    firstAllCards.Enqueue(firstCard);
                    firstAllCards.Enqueue(secondCard);
                }
                else if (GetNumber(firstCard) < GetNumber(secondCard))
                {
                    secondAllCards.Enqueue(secondCard);
                    secondAllCards.Enqueue(firstCard);
                }
                else
                {
                    List<string> cardsHand = new List<string> { firstCard, secondCard };

                    while (!gameOver)
                    {
                        if (firstAllCards.Count >= 3 &&
                            secondAllCards.Count >= 3)
                        {
                            int firstSum = 0;
                            int secondSum = 0;

                            for (int i = 0; i < 3; i++)
                            {
                                string firstHandCard = firstAllCards.Dequeue();
                                string secondHandCard = secondAllCards.Dequeue();

                                firstSum += GetChar(firstHandCard);
                                secondSum += GetChar(secondHandCard);

                                cardsHand.Add(firstHandCard);
                                cardsHand.Add(secondHandCard);
                            }

                            // int comparison = firstSum.CompareTo(secondSum);
                            if (firstSum > secondSum)
                            {
                                AddCardsToWiner(cardsHand, firstAllCards);
                                break;
                            }
                            else if (firstSum < secondSum)
                            {
                                AddCardsToWiner(cardsHand, secondAllCards);
                                break;
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }
                    }
                }
            }

            string result = string.Empty;

            if (firstAllCards.Count == secondAllCards.Count)
            {
                result = "Draw";
            }
            else if (firstAllCards.Count > secondAllCards.Count)
            {
                result = "First player wins";
            }
            else
            {
                result = "Second player wins";
            }

            Console.WriteLine($"{result} after {turnsCounter} turns");
        }

        static void AddCardsToWiner(
            List<string> cardsHand, 
            Queue<string> firstAllCards)
        {
            foreach (string card in cardsHand
                .OrderByDescending(x => GetNumber(x))
                .ThenByDescending(x => GetChar(x)))
            {
                firstAllCards.Enqueue(card);
            }
        }

        static int GetNumber(string card)
        {
            return int.Parse(card.Substring(0, card.Length - 1));
        }

        static int GetChar(string card)
        {
            return card[card.Length - 1];
        }
    }
}
