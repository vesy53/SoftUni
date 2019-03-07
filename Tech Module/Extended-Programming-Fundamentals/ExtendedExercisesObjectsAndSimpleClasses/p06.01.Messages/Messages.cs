using System;
using System.Collections.Generic;
using System.Linq;

class Messages
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<User> users = new List<User>();

        while (input.Equals("exit"))
        {
            string[] inputTokens = input
                .Split();

            if (inputTokens.Length == 2)
            {
                string username = inputTokens[1];

                User user = new User
                {
                    Username = username,
                    ReceivedMessages = new List<Message>()
                };

                users.Add(user);
            }
            else
            {
                string senderUsername = inputTokens[0];
                string recipientUsername = inputTokens[2];
                string content = inputTokens[3];

                if (users.Exists(u => u.Username == senderUsername) &&
                    users.Exists(x => x.Username == recipientUsername))
                {
                    var sender = users.Find(x => x.Username == senderUsername);

                    Message message = new Message
                    {
                        Sender = sender,
                        Content = content
                    };
                }
            }

            input = Console.ReadLine();
        }
    }
}

class User
{
    public string Username { get; set; }
    public List<Message> ReceivedMessages { get; set; }
}

class Message
{
    public string Content { get; set; }
    public User Sender { get; set; }
}