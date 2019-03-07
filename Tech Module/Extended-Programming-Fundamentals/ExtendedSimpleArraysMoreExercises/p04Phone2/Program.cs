using System;
using System.Linq;

namespace p04Phone2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNum = Console.ReadLine()
                .Split()
                .ToArray();
            string[] contacts = Console.ReadLine()
                .Split()
                .ToArray();
            string[] commandsArgs = Console.ReadLine()
                .Split()
                .ToArray();

            while (commandsArgs[0] != "done")
            {
                if (commandsArgs[0].Equals("call"))
                {
                    //Получаваме низа в позиция 1 на потребителския вход(номер или име) и ако LAST 
                    //символът на този низ е цифра, ние знаем, че имаме телефона. Ако не, тогава 
                    //имаме името. Проверяваме последния знак, защото първият може да бъде "+", 
                    //но последният може да бъде само цифра или буква.
                    if (char.IsDigit(commandsArgs[1][commandsArgs.Length - 1]))
                    {
                        int indexPhone = Array.IndexOf(phoneNum, commandsArgs[1]);
                        Console.WriteLine($"calling {contacts[indexPhone]}...");

                        string phoneNumber = commandsArgs[1];

                        PrintCallSummary(phoneNumber);
                    }
                    else
                    {
                        int personIndex = Array.IndexOf(contacts, commandsArgs[1]);
                        Console.WriteLine($"calling {phoneNum[personIndex]}...");

                        string pnoneNumber = phoneNum[personIndex];

                        PrintCallSummary(pnoneNumber);
                    }
                }
                else if (commandsArgs[0].Equals("message"))
                {
                    //Получаваме низа в позиция 1 на потребителския вход(номер или име) и ако LAST 
                    //символът на този низ е цифра, ние знаем, че имаме телефона. Ако не, тогава 
                    //имаме името. Проверяваме последния знак, защото първият може да бъде "+", 
                    //но последният може да бъде само цифра или буква.
                    if (char.IsDigit(commandsArgs[1][commandsArgs.Length - 1]))
                    {
                        int indexPhone = Array.IndexOf(phoneNum, commandsArgs[1]);
                        Console.WriteLine($"sending sms to {contacts[indexPhone]}...");

                        string phoneNumber = commandsArgs[1];

                        PrintMessageResult(phoneNumber);
                    }
                    else
                    {
                        int personIndex = Array.IndexOf(contacts, commandsArgs[1]);
                        Console.WriteLine($"calling {phoneNum[personIndex]}...");

                        string pnoneNumber = phoneNum[personIndex];

                        PrintMessageResult(pnoneNumber);
                    }
                }

                commandsArgs = Console.ReadLine().Split().ToArray();
            }
        }

        static void PrintMessageResult(string phoneNumber)
        {
            int diff = 0;

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                int currentDigit = 0;
                bool isTheCharDigit = int.TryParse(phoneNumber[i].ToString(), out currentDigit);
                diff -= currentDigit;
            }

            if (diff % 2 == -1)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }

        static void PrintCallSummary(string phoneNumber)
        {
            int sum = 0;

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                int currentDigit = 0;
                // С помощта на TryParse() проверяваме дали текущият знак на числото е цяло число (например "+" не е число).
                //Ако е вярно, запазваме цифрата в променливата след ключовата дума "out" на метода.
                //Ако е фалшиво, ние не правим нищо с него.
                bool isTheCharDigit = int.TryParse(phoneNumber[i].ToString(), out currentDigit);
                sum += currentDigit;
            }

            if (sum % 2 == 1)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                int minutes = sum / 60;
                int seconds = sum % 60;

                Console.WriteLine($"call ended. duration: {minutes:D2}:{seconds:D2}");
            }
        }
    }
}
