namespace p05._01.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IIdentifiable> data = new List<IIdentifiable>();

            string input = Console.ReadLine();

            while (input.Equals("End") == false)
            {
                string[] tokens = input
                    .Split(" ");

                string name = tokens[0];

                if (tokens.Length == 3)
                {
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];

                    Citizen citizen = new Citizen(name, age, id);

                    data.Add(citizen);
                }
                else if (tokens.Length == 2)
                {
                    string id = tokens[1];

                    Robot robot = new Robot(name, id);

                    data.Add(robot);
                } 

                input = Console.ReadLine();
            }

            string lastDigits = Console.ReadLine();

            foreach (IIdentifiable item in data
                .Where(c => c.Id.EndsWith(lastDigits)))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
