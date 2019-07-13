namespace p06._01.BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBirthdate> birthdates = new List<IBirthdate>();

            string input = Console.ReadLine();

            while (input.Equals("End") == false)
            {
                string[] tokens = input
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0].ToLower();
                string name = tokens[1];

                if (command == "citizen")
                {
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    string birthdate = tokens[4];

                    Citizen citizen = new Citizen(
                        name, 
                        age, 
                        id, 
                        birthdate);

                    birthdates.Add(citizen);
                }
                else if (command == "pet")
                {
                    string birthdate = tokens[2];

                    Pet pet = new Pet(name, birthdate);

                    birthdates.Add(pet);
                }

                input = Console.ReadLine();
            }

            string year = Console.ReadLine();

            bool isExist = birthdates
                .Any(b => b.Birthdate.EndsWith(year));

            if (!isExist)
            {
                Console.WriteLine();
            }
            else
            {
                foreach (IBirthdate birthdate in birthdates
                    .Where(b => b.Birthdate.EndsWith(year)))
                {
                    Console.WriteLine(birthdate.Birthdate);
                }
            }
        }
    }
}
