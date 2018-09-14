namespace p03._01.KarateStrings
{
    using System;

    class KarateStrings //66/100
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int index = input.IndexOf('>');
            int number = 0;

            for (int i = index; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    number += int.Parse(input[i + 1].ToString());
                    
                    i++;

                    while (i < input.Length && number > 0)
                    {
                        if (input[i] == '>')
                        {
                            break;
                        }

                        input = input.Remove(i, 1);
                        number--;
                    }

                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
