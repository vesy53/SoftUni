namespace p02._02.ChatLogger
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
                        result = Add(result, message);
                        break;
                    case "Delete":
                        message = tokens[1];
                        result = Delete(result, message);
                        break;
                    case "Edit":
                        message = tokens[1];
                        string editedVersion = tokens[2];
                        result = Edit(result, message, editedVersion);
                        break;
                    case "Pin":
                        message = tokens[1];
                        result = Pin(result, message);
                        break;
                    case "Spam":
                        List<string> messages = tokens
                            .Skip(1)
                            .ToList();
                        result = Spam(result, messages);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        static List<string> Spam(
            List<string> result, 
            List<string> messages)
        {
            result.AddRange(messages);

            return result;
        }

        static List<string> Pin(
            List<string> result,
            string message)
        {
            if (result.Contains(message))
            {
                int index = result.IndexOf(message);
                result.RemoveAt(index);
                result.Add(message);
            }

            return result;
        }

        static List<string> Edit(
            List<string> result, 
            string message, 
            string editedVersion)
        {
            if (result.Contains(message))
            {
                int index = result.IndexOf(message);
                result.RemoveAt(index);
                result.Insert(index, editedVersion);
            }

            return result;
        }

        static List<string> Delete(
            List<string> result, 
            string message)
        {
            if (result.Contains(message))
            {
                int index = result.IndexOf(message);
                result.RemoveAt(index);
            }

            return result;
        }

        static List<string> Add(
            List<string> result, 
            string message)
        {
            result.Add(message);

            return result;
        }
    }
}
