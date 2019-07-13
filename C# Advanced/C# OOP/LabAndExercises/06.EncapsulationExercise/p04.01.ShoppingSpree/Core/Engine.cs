namespace p04._01.ShoppingSpree.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using IO.Contracts;
    using p04._01.ShoppingSpree.Models;

    public class Engine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            try
            {
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();

                string[] inputPeople = reader.ReadLine()
                    .Split(';',
                        StringSplitOptions
                        .RemoveEmptyEntries);
                string[] inputProducts = reader.ReadLine()
                    .Split(';',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                FullTheListPeople(people, inputPeople);

                FullTheListProducts(products, inputProducts);

                string input = Console.ReadLine();

                while (input.Equals("END") == false)
                {
                    string[] tokens = input
                        .Split(" ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string personName = tokens[0];
                    string productName = tokens[1];

                    Person person = people
                        .FirstOrDefault(p => p.Name == personName);

                    Product product = products
                        .FirstOrDefault(p => p.Name == productName);

                    if (person == null ||
                        product == null)
                    {
                        input = reader.ReadLine();
                        continue;
                    }

                    string result = people
                        .First(p => p.Name == personName)
                        .AddProduct(product);

                    writer.WriteLine(result);

                    input = reader.ReadLine();
                }

                Print(people);
            }
            catch (ArgumentException ae)
            {
                writer.WriteLine(ae.Message);
            }
        }

        private void Print(List<Person> people)
        {
            foreach (Person person in people)
            {
                writer.WriteLine(person.ToString());
            }
        }

        private static void FullTheListProducts(
            List<Product> products, 
            string[] inputProducts)
        {
            foreach (string productArg in inputProducts)
            {
                string[] tokens = productArg
                    .Split('=');

                string name = tokens[0];
                decimal cost = decimal.Parse(tokens[1]);

                Product product = new Product(name, cost);

                products.Add(product);
            }
        }

        private static void FullTheListPeople(
            List<Person> people, 
            string[] inputPeople)
        {
            foreach (string personArg in inputPeople)
            {
                string[] tokens = personArg
                    .Split('=');

                string name = tokens[0];
                decimal money = decimal.Parse(tokens[1]);

                Person person = new Person(name, money);

                people.Add(person);
            }
        }
    }
}
