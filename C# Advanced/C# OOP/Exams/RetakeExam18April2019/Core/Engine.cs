namespace PlayersAndMonsters.Core
{
    using System;

    using Contracts;
    using PlayersAndMonsters.IO;
    using PlayersAndMonsters.IO.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IManagerController managerController;

        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();

            this.managerController = new ManagerController();
        }

        public void Run()
        {
            string input = this.reader.ReadLine();

            while (input.Equals("Exit") == false)
            {
                try
                {
                    string[] tokens = input
                        .Split(" ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string command = tokens[0];

                    string result = string.Empty;

                    switch (command)
                    {
                        case "AddPlayer":
                            string playerType = tokens[1];
                            string playerUsername = tokens[2];

                            result = this.managerController
                                .AddPlayer(playerType, playerUsername);
                            break;
                        case "AddCard":
                            string cardType = tokens[1];
                            string name = tokens[2];

                            result = this.managerController
                                .AddCard(cardType, name);
                            break;
                        case "AddPlayerCard":
                            string username = tokens[1];
                            string cardName = tokens[2];

                            result = this.managerController
                                .AddPlayerCard(username, cardName);
                            break;
                        case "Fight":
                            string attackUser = tokens[1];
                            string enemyUser = tokens[2];

                            result = this.managerController
                                .Fight(attackUser, enemyUser);
                            break;
                        case "Report":
                            result = this.managerController
                                .Report();
                            break;
                    }

                    this.writer.WriteLine(result);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }

                input = this.reader.ReadLine();
            }

        }
    }
}
