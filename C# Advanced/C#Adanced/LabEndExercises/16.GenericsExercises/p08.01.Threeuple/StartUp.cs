namespace p08._01.Threeuple
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
            string[] bankArgs = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string fullName = $"{personData[0]} {personData[1]}";
            string address = personData[2];
            string town = personData[3];

            string name = nameAndBeer[0];
            int litersOfBeer = int.Parse(nameAndBeer[1]);
            string drunkOrNot = nameAndBeer[2];

            bool isDrunk = drunkOrNot.ToLower() == "drunk" ?
                true :
                false;

            string personName = bankArgs[0];
            double accountBalance = double.Parse(bankArgs[1]);
            string bankName = bankArgs[2];

            var personTuple = new Threeuple<string, string, string>(fullName, address, town);
            var nameAndBeerTuple = new Threeuple<string, int, bool>(name, litersOfBeer, isDrunk);
            var bankTuple = new Threeuple<string, double, string>(personName, accountBalance, bankName);
            
            //(string Name, double Balance, string BankName) bankTuple = (Name: personName, Balance: accountBalance, BankName: bankName);
            //Console.WriteLine($"{bankTuple.Name} -> {bankTuple.Balance} -> {bankTuple.BankName}");

            Console.WriteLine(personTuple);
            Console.WriteLine(nameAndBeerTuple);
            Console.WriteLine(bankTuple);
        }
    }
}
