using System;

namespace p16Number0To100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num < 20)
            {
                switch (num)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                }
            }
            else if (num >= 20 && num < 100)
            {
                int firstDigit = num / 10;
                int secDigit = num % 10;

                switch (firstDigit)
                {
                    case 2:
                        Console.Write("twenty");
                        break;
                    case 3:
                        Console.Write("thirty");
                        break;
                    case 4:
                        Console.Write("forty");
                        break;
                    case 5:
                        Console.Write("fifty");
                        break;
                    case 6:
                        Console.Write("sixty");
                        break;
                    case 7:
                        Console.Write("seventy");
                        break;
                    case 8:
                        Console.Write("eighty");
                        break;
                    case 9:
                        Console.Write("ninety");
                        break;
                }

                switch(secDigit)
                {
                    case 1:
                        Console.WriteLine(" one");
                        break;
                    case 2:
                        Console.WriteLine(" two");
                        break;
                    case 3:
                        Console.WriteLine(" three");
                        break;
                    case 4:
                        Console.WriteLine(" four");
                        break;
                    case 5:
                        Console.WriteLine(" five");
                        break;
                    case 6:
                        Console.WriteLine(" six");
                        break;
                    case 7:
                        Console.WriteLine(" seven");
                        break;
                    case 8:
                        Console.WriteLine(" eight");
                        break;
                    case 9:
                        Console.WriteLine(" nine");
                        break;
                }
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (num < 0 || num > 100)
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
