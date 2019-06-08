namespace p12._01.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input.Equals("End") == false)
            {

                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = tokens[0];
                string command = tokens[1];
                string nameParam = tokens[2];

                Person person = people
                    .Where(p => p.Name == name)
                    .FirstOrDefault();

                if (person == null)
                {
                    person = new Person(name);

                    people.Add(person);
                }

                switch (command)
                {
                    case "company":
                        string department = tokens[3];
                        decimal salary = decimal.Parse(tokens[4]);

                        Company company = new Company(nameParam, department, salary);
                        person.AddCompany(company);
                        break;
                    case "pokemon":
                        string type = tokens[3];

                        Pokemon pokemon = new Pokemon(nameParam, type);
                        person.AddPokemon(pokemon);
                        break;
                    case "parents":
                        string birthday = tokens[3];

                        Parent parent = new Parent(nameParam, birthday);
                        person.AddParent(parent);
                        break;
                    case "children":
                        string childBirthday = tokens[3];

                        Child child = new Child(nameParam, childBirthday);
                        person.AddChild(child);
                        break;
                    case "car":
                        int speed = int.Parse(tokens[3]);

                        Car car = new Car(nameParam, speed);
                        person.AddCar(car);
                        break;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            Person personResult = people
                .FirstOrDefault(p => p.Name == input);

            if (personResult != null)
            {
                Console.Write(personResult.ToString());
            }

            Console.WriteLine();
        }
    }
}
