namespace p01._02.ClubParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ClubParty
    {
        static void Main(string[] args)
        {
            int hallsMaxCapacity = int.Parse(Console.ReadLine());
            string[] elements = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Stack<string> allElements = new Stack<string>(elements);

            Queue<char> letters = new Queue<char>();
            Queue<int> capacity = new Queue<int>();
            int sumCapacity = 0;

            while (allElements.Count > 0)
            {
                string currentElement = allElements.Pop();

                int digit = 0;
                bool isDidit = int.TryParse(currentElement, out digit);

                if (isDidit)
                {
                    if (letters.Count != 0)
                    {
                        sumCapacity += digit;

                        if (sumCapacity <= hallsMaxCapacity)
                        {
                            capacity.Enqueue(digit);
                        }
                        else
                        {
                            Console.WriteLine(
                                $"{letters.Dequeue()} -> {string.Join(", ", capacity)}");

                            capacity = new Queue<int>();

                            if (letters.Count != 0)
                            {
                                capacity.Enqueue(digit);
                                sumCapacity = 0;
                                sumCapacity += digit;
                            }
                            else
                            {
                                sumCapacity = 0;
                            }
                        }
                    }
                }
                else
                {
                    char currentLetter = char.Parse(currentElement);

                    letters.Enqueue(currentLetter);
                }
            }
        }
    }
}
