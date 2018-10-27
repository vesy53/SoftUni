using System;

namespace p04Phone4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNum = Console.ReadLine()
                .Split();
            string[] contacts = Console.ReadLine()
                .Split();
            string commandsArgs = Console.ReadLine(); 

            while (commandsArgs != "done")
            {
                string[] inputCommands = commandsArgs.Split();
                string command = inputCommands[0];
                string numOrName = inputCommands[1];

                for (int i = 0; i < contacts.Length; i++)
                {
                    if (command.Equals("call"))
                    {
                        if (numOrName.Equals(phoneNum[i]))
                        {
                            CallNumber(phoneNum[i], contacts[i]);
                        }
                        else if (numOrName.Equals(contacts[i]))
                        {
                            CallName(phoneNum[i]);
                        }
                    }

                    if (command.Equals("message"))
                    {
                        if (numOrName.Equals(phoneNum[i]))
                        {
                            MessageNumber(phoneNum[i], contacts[i]);
                        }
                        else if (numOrName.Equals(contacts[i]))
                        {
                            MessageName(phoneNum[i]);
                        }
                    }
                }

                commandsArgs = Console.ReadLine();
            }
        }

        static void MessageName(string v)
        {
            Console.WriteLine($"sending sms to {v}...");

            int sum = 0;
            foreach (char t in v)
            {
                if (t >= 49 && t <= 57)
                {
                    sum += t - 48;
                }
            }

            Console.WriteLine(sum % 2 == 0 ? "meet me there" : "busy");
        }

        static void MessageNumber(string v1, string v2)
        {
            Console.WriteLine($"sending sms to {v2}...");

            int sum = 0;

            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] >= 49 && v1[i] <= 57)
                {
                    sum += v1[i] - 48;
                }
            }

            Console.WriteLine(sum % 2 == 0 ? "meet me there" : "busy");
        }

        static void CallName(string v)
        {
            Console.WriteLine($"calling {v}...");

            int sum = 0;

            foreach (char t in v)
            {
                if (t >= 49 && t <= 57)
                {
                    sum += t - 48;
                }
            }

            TimeSpan time = TimeSpan.FromSeconds(sum);

            if (sum % 2 == 0)
            {
                Console.WriteLine(
                    $"call ended. duration: {time.Minutes:00}:{time.Seconds:00}");
            }
            else
            {
                Console.WriteLine("no answer");
            }
        }

        static void CallNumber(string v1, string v2)
        {
            Console.WriteLine($"calling {v2}...");

            int sum = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] >= 49 && v1[i] <= 57)
                {
                    sum += v1[i] - 48;
                }
            }

            TimeSpan time = TimeSpan.FromSeconds(sum);

            switch (sum % 2)
            {
                case 0:
                    Console.WriteLine(
                        $"call ended. duration: {time.Minutes:00}:{time.Seconds:00}");
                    break;
                default:
                    Console.WriteLine("no answer");
                    break;
            }
        }
    }
}
