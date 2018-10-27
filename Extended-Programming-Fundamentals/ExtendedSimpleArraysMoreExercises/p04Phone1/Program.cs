using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p04Phone1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phoneNum = Console.ReadLine()
                .Split()
                .ToList();
            List<string> contacts = Console.ReadLine()
                .Split()
                .ToList();
            string[] commandArgs = Console.ReadLine()
                .Split();

            StringBuilder result = new StringBuilder();

            while (commandArgs[0] != "done")
            {
                string command = commandArgs[0];

                if (command.Equals("call"))
                {
                    int sum = 0;
                    string currentPhone = string.Empty;

                    if (commandArgs[1].ToCharArray().Any(x => char.IsDigit(x)))
                    {
                        string phone = commandArgs[1];

                        sum = phone.Where(x => char.IsDigit(x)).Select(x => (int)char.GetNumericValue(x)).Sum();
                        int index = phoneNum.IndexOf(phone);
                        result.AppendLine($"calling {contacts[index]}...");
                    }
                    else
                    {
                        string name = commandArgs[1];

                        int index = contacts.IndexOf(name);
                        sum = phoneNum[index].Where(x => char.IsDigit(x)).Select(x => (int)char.GetNumericValue(x)).Sum();
                        result.AppendLine($"calling {phoneNum[index]}...");
                    }

                    if (sum % 2 != 0)
                    {
                        result.AppendLine("no answer");
                    }
                    else
                    {
                        int minutes = sum / 60;
                        int seconds = sum % 60;

                        result.AppendLine($"call ended. duration: {minutes:00}:{seconds:00}");
                    }
                }
                else if(command.Equals("message"))
                {
                    string currentPhone = string.Empty;

                    if (commandArgs[1].ToCharArray().Any(x => char.IsDigit(x)))
                    {
                        string phone = commandArgs[1];
                        currentPhone = phone;
                        int index = phoneNum.IndexOf(phone);
                        result.AppendLine($"sending sms to {phoneNum[index]}...");
                    }
                    else
                    {
                        string name = commandArgs[1];
                        int index = contacts.IndexOf(name);
                        currentPhone = phoneNum[index];
                        result.AppendLine($"sending sms to {phoneNum[index]}...");
                    }

                    int diff = 0;

                    for (int i = 0; i < currentPhone.Length; i++)
                    {
                        if (char.IsDigit(currentPhone[i]))
                        {
                            int currentNum = (int)char.GetNumericValue(currentPhone[i]);
                            diff -= currentNum;
                        }
                    }

                    if (diff % 2 == -1)
                    {
                        result.AppendLine("busy");
                    }
                    else
                    {
                        result.AppendLine("meet me there");
                    }
                }

                commandArgs = Console.ReadLine().Split();
            }

            Console.WriteLine(result);
        }
    }
}
