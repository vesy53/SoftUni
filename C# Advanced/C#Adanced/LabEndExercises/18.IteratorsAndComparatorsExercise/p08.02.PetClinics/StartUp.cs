namespace p08._02.PetClinics
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Controller controller = new Controller();

            int countOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLines; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split();

                string command = tokens[0];

                tokens = tokens.Skip(1).ToArray();

                try
                {
                    switch (command)
                    {
                        case "Create":
                            controller.Create(tokens);
                            break;
                        case "Add":
                            controller.Add(tokens);
                            break;
                        case "Release":
                            controller.Release(tokens[0]);
                            break;
                        case "HasEmptyRooms":
                            controller.HasEmptyRooms(tokens[0]);
                            break;
                        case "Print":
                            controller.PreparePrint(tokens);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
