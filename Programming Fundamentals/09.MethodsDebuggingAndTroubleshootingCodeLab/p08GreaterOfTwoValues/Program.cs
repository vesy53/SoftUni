using System;

namespace p08GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int maxNum = GetMax(firstNum, secondNum);

                Console.WriteLine(maxNum);
            }
            else if (type == "char")
            {
                char firstSymbol = char.Parse(Console.ReadLine());
                char secondSymbol = char.Parse(Console.ReadLine());

                char maxSymbol = GetMax(firstSymbol, secondSymbol);

                Console.WriteLine(maxSymbol);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                string max = GetMax(first, second);

                Console.WriteLine(max);
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static int GetMax(int firstNum, int secondNum)
        {
             if (firstNum >= secondNum)
             {
                 return firstNum;
             }
             else
             {
                 return secondNum;         
             }
        }

        static char GetMax(char firstSymbol, char secondSymbol)
        {
            if (firstSymbol >= secondSymbol)
            {
                return firstSymbol;
            }
            else
            {
                return secondSymbol;
            }
        }
    }
}
