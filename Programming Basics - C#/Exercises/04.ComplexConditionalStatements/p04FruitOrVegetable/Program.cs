using System;

namespace p04FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            if (product == "banana" || product == "kiwi" 
                || product == "cherry" || product == "lemon"
                || product == "grapes" || product == "apple")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "cucumber"
                || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else 
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
