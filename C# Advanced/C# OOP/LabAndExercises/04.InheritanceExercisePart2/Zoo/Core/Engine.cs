namespace Zoo.Core
{
    using System;

    using Zoo.Animals.Mammals;
    using Zoo.Animals.Reptiles;

    public class Engine
    {
        public void Run()
        {
            Lizard lizard = new Lizard("Gogo");
            Snake snake = new Snake("Pesho");
            Gorilla gorilla = new Gorilla("King Kong");
            Bear bear = new Bear("Gosho");

            Console.WriteLine(lizard.Name);
            Console.WriteLine(snake.Name);
            Console.WriteLine(gorilla.Name);
            Console.WriteLine(bear.Name);
        }
    }
}
