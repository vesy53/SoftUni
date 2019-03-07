using System;
using System.Collections.Generic;

class Messages
{
    static void Main(string[] args)
    {
        //88/100
        string input = Console.ReadLine();

        Dictionary<string, List<Message>> usersData = new Dictionary<string, List<Message>>();
        List<string> senderReceiver = new List<string>();

        while (input.Equals("exit") == false)
        {
            string[] inputTokens = input
                .Split();

            if (inputTokens.Length == 2)
            {
                string username = inputTokens[1];

                if (!usersData.ContainsKey(username))
                {
                    usersData.Add(username, new List<Message>());
                }
            }
            else
            {
                string sender = inputTokens[0];
                string recipient = inputTokens[2];
                string content = inputTokens[3];

                if (usersData.ContainsKey(sender) &&
                    usersData.ContainsKey(recipient))
                {
                    Message message = new Message()
                    {
                        Content = content,
                        Sender = sender,
                    };

                    senderReceiver.Add(sender);
                    senderReceiver.Add(recipient);

                    usersData[sender].Add(message);
                }
            }

            input = Console.ReadLine();
        }

        string[] chatTokens = Console.ReadLine()
            .Split();

        string first = chatTokens[0];
        string second = chatTokens[1];

        List<string> firstMessages = new List<string>();
        List<string> secondMessages = new List<string>();


        foreach (var user in usersData)
        {
            List<Message> messages = user.Value;

            foreach (Message message in messages)
            {
                if (message.Sender == first)
                {
                    firstMessages.Add(message.Content);
                }
                else if (message.Sender == second)
                {
                    secondMessages.Add(message.Content);
                }
            }
        }

        if (firstMessages.Count == 0 &&
            secondMessages.Count == 0)
        {
            Console.WriteLine("No messages");
        }
        else
        {
            int count1 = firstMessages.Count;
            int count2 = secondMessages.Count;

            if (count1 >= count2)
            {
                PrintRegularChat(firstMessages, first, secondMessages, second);

                for (int i = count2; i < count1; i++)
                {
                    string currentMessage = firstMessages[i];

                    Console.WriteLine($"{first}: {currentMessage}");
                }
            }
            else
            {
                PrintRegularChat(firstMessages, first, secondMessages, second);

                for (int i = count1; i < count2; i++)
                {
                    string currentMessage = secondMessages[i];

                    Console.WriteLine($"{currentMessage} :{second}");
                }
            }
        }
    }

    static void PrintRegularChat(
        List<string> firstMessages,
        string first,
        List<string> secondMessages,
        string second)
    {

        for (int i = 0; i < Math.Min(firstMessages.Count, secondMessages.Count); i++)
        {
            string firstMessage = firstMessages[i];
            string secondMessage = secondMessages[i];

            Console.WriteLine($"{first}: {firstMessage}");
            Console.WriteLine($"{secondMessage} :{second}");
        }
    }
}

class Message
{
    public string Content { get; set; }
    public string Sender { get; set; }
}