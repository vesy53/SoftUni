using System;

namespace p07CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredients = Console.ReadLine();

            int counter = 0;

            while (ingredients != "Bake!")
            {
                counter++;

                Console.WriteLine($"Adding ingredient {ingredients}.");

                ingredients = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
