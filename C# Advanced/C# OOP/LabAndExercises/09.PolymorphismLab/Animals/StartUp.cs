namespace Animals
{
    using System;

    using Contracts;
    using Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IAnimal cat = new Cat("Pesho", "Whiskas");
            IAnimal dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

        }
    }
}
