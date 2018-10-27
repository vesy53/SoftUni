using System;
using System.Linq;

namespace p04Phone3
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
                    CallMethod(phoneNum, contacts, commandsArgs);
                }
                else if (commandsArgs[0].Equals("message"))
                {
                    MessageMethod(phoneNum, contacts, commandsArgs);
                }

                commandsArgs = Console.ReadLine().Split().ToArray();
            }
        }

        static void MessageMethod(string[] phoneNum, string[] contacts, string[] commandsArgs)
        {
            long sum = 0;

            for (int i = 0; i < contacts.Length; i++)
            {
                if (commandsArgs[1].Equals(phoneNum[i]))
                {
                    Console.WriteLine($"sending sms to {contacts[i]}...");

                    var sumOfDigits = phoneNum[i].ToCharArray();

                    foreach (var s in sumOfDigits)
                    {
                        if (s >= 48 && s <= 57)
                        {
                            sum += s - '0';
                        }
                    }
                }
                else if (commandsArgs[1].Equals(contacts[i]))
                {
                    Console.WriteLine($"sending sms to {phoneNum[i]}...");

                    var sumOfDigits = phoneNum[i].ToCharArray();

                    foreach (var s in sumOfDigits)
                    {
                        if (s >= 48 && s <= 57)
                        {
                            sum += s - '0';
                        }
                    }
                }
            }

            if (sum % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else if (sum % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
        }

        static void CallMethod(string[] phoneNum, string[] contacts, string[] commandsArgs)
        {
            long duration = 0;

            for (int i = 0; i < contacts.Length; i++)
            {
                if (commandsArgs[1].Equals(phoneNum[i]))
                {
                    Console.WriteLine($"calling {contacts[i]}...");

                    var sumOfDigits = phoneNum[i].ToCharArray();

                    foreach (var s in sumOfDigits)
                    {
                        if (s >= 48 && s <= 57)
                        {
                            duration += s - '0';
                        }
                    }
                }
                else if (commandsArgs[1].Equals(contacts[i]))
                {
                    Console.WriteLine($"calling {phoneNum[i]}...");

                    var sumOfDigit = phoneNum[i].ToCharArray();

                    foreach (var s in sumOfDigit)
                    {
                        if (s >= 48 && s <= 57)
                        {
                            duration += s - '0';
                        }
                    }               
                }

            }

             if (duration % 2 != 0)
             {
                 Console.WriteLine("no answer");
             }
             else if (duration % 2 == 0)
             {
                 TimeSpan time = TimeSpan.FromSeconds(duration);
                 string answer = string.Format("call ended. duration: {0:D2}:{1:D2}",
                     time.Minutes,
                     time.Seconds);

                 Console.WriteLine(answer);
             }
        }
    }
}
