namespace p07._01.FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Creature> creatures = new List<Creature>();
                
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                if (tokens.Length == 4)
                {
                    string id = tokens[2];
                    string birthdate = tokens[3];

                    Citizen citizen = new Citizen(
                        name,
                        age,
                        id,
                        birthdate);

                    creatures.Add(citizen);
                }
                else if (tokens.Length == 3)
                {
                    string group = tokens[2];

                    Rebel rebel = new Rebel(name, age, group);

                    creatures.Add(rebel);
                }
            }

            string inputName = Console.ReadLine();

            while (inputName.Equals("End") == false)
            {
                Creature searchName = creatures
                    .FirstOrDefault(b => b.Name == inputName);

                searchName?.BuyFood();

                inputName = Console.ReadLine();
            }

            int totalSum = creatures.Sum(c => c.Food);

            Console.WriteLine(totalSum);
        }
    }
}
