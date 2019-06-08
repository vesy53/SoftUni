namespace p07._01.Tuple
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personData = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] nameAndBeer = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] intAndDouble = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string fullName = $"{personData[0]} {personData[1]}";
            string address = personData[2];

            string name = nameAndBeer[0];
            int litersOfBeer = int.Parse(nameAndBeer[1]);

            int integer = int.Parse(intAndDouble[0]);
            double doubleNum = double.Parse(intAndDouble[1]);

            Tuple<string, string> personTuple = new Tuple<string, string>(fullName, address);
            Tuple<string, int> nameAndBeerTuple = new Tuple<string, int>(name, litersOfBeer);
            Tuple<int, double> intDoubleTuple = new Tuple<int, double>(integer, doubleNum);

            Console.WriteLine(personTuple);
            Console.WriteLine(nameAndBeerTuple);
            Console.WriteLine(intDoubleTuple);
        }
    }
}
