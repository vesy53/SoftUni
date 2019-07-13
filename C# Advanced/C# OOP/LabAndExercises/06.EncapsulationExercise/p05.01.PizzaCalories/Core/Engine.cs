namespace p05._01.PizzaCalories.Core
{
    using System;

    using IO.Contracts;
    using p05._01.PizzaCalories.Models;

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
                string[] pizzaInput = reader
                    .ConsoleReadLine()
                    .Split(" ");
                string[] doughInput = reader
                    .ConsoleReadLine()
                    .Split(" ");

                string pizzaName = pizzaInput[1];

                string flour = doughInput[1];
                string baking = doughInput[2];
                double weightInGrams = double.Parse(doughInput[3]);

                Dough dough = new Dough(flour, baking, weightInGrams);

                Pizza pizza = new Pizza(pizzaName, dough);

                string input = reader.ConsoleReadLine();

                while (input.Equals("END") == false)
                {
                    string[] toppingArgs = input
                        .Split(" ");

                    string type = toppingArgs[1];
                    double weight = double.Parse(toppingArgs[2]);

                    Topping topping = new Topping(type, weight);

                    pizza.AddTopping(topping);

                    input = reader.ConsoleReadLine();
                }

                writer.ConsoleWriteLine(pizza.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
