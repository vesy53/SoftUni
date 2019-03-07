namespace p02._01.ChatLogger
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class ChatLogger
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> result = new List<string>();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Chat":
                        string message = tokens[1];

                        result.Add(message);
                        break;
                    case "Delete":
                        message = tokens[1];

                        if (result.Contains(message))
                        {
                            int index = result.IndexOf(message);
                            result.RemoveAt(index);
                        }
                        break;
                    case "Edit":
                        message = tokens[1];
                        string editedVersion = tokens[2];

                        if (result.Contains(message))
                        {
                            int index = result.IndexOf(message);
                            result.RemoveAt(index);
                            result.Insert(index, editedVersion);
                        }
                        break;
                    case "Pin":
                        message = tokens[1];

                        if (result.Contains(message))
                        {
                            int index = result.IndexOf(message);
                            result.RemoveAt(index);
                            result.Add(message);
                        }
                        break;
                    case "Spam":
                        List<string> messages = tokens
                            .Skip(1)
                            .ToList();

                        result.AddRange(messages);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
